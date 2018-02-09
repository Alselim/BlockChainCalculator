﻿using ITUniver.Calc.Core.Interfaces;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ITUniver.Calc.WinFormApp
{
    public partial class Form1 : Form
    {

        private ConsoleCalc.Calc calc { get; set; }

        private IOperation lastOperation { get; set; }

        public Form1()
        {
            InitializeComponent();

            #region Загрузка операций

            calc = new ConsoleCalc.Calc();

            cbOperation.DataSource = calc.GetOpers();
            cbOperation.DisplayMember = "Name";

            btnCalc.Enabled = false;
            #endregion

        }

        private void btnLuck_Click(object sender, EventArgs e)
        {
            tbResult.Text = "Успех!";
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            tbInput.Focus();
            tbInput_Click(sender, e);

            if (lastOperation == null)
                return;

            // получить данные
            var args = tbInput.Text
                .Trim()
                .Split(' ')
                .Select(str => Convert.ToDouble(str))
                .ToArray();

            // вычислить результат
            var result = lastOperation.Exec(args);

            // показать результат
            tbResult.Text = $"{result}";

            // добавить в историю в БД
            MyHelper.AddToHistory(lastOperation.Name, args, result);
            // добавить в историю на форму
            //lbHistory.Items.Add($"{result}");
            var items = MyHelper.GetAll();
            lbHistory.Items.Clear();
            lbHistory.Items.AddRange(items.Select(it => it.Result.ToString()).ToArray());

        }

        private void cbOperation_SelectedIndexChanged(object sender, EventArgs e)
        {
            // получить операцию
            lastOperation = cbOperation.SelectedItem as IOperation;

            tbInput.Enabled = true;
        }

        private void tbInput_TextChanged(object sender, EventArgs e)
        {
            btnCalc.Enabled = !string.IsNullOrWhiteSpace(tbInput.Text);
        }

        private void tbInput_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnCalc_Click(sender, e);
            }
        }

        private void tbInput_Click(object sender, EventArgs e)
        {
            tbInput.SelectAll();
        }
    }
}
