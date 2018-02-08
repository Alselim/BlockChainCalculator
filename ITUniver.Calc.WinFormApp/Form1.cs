using ITUniver.Calc.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
