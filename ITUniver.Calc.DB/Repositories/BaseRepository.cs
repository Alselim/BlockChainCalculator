using System;
using System.Collections.Generic;
using ITUniver.Calc.DB.Models;
using System.Data.SqlClient;
using System.Data;
using System.Globalization;

namespace ITUniver.Calc.DB.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T>
        where T : IEntity
    {
        // todo: вынести в конфиг
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\BlockchainCalculator\ITUniver.Calc.DB\App_Data\CalcDB.mdf;Integrated Security=True";

        public void Delete(long id)
        {
            throw new NotImplementedException();
        }

        public T Find(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            return null;
        }

        public void Save(T item)
        {
            /*
            var doubleResult = item.Result.HasValue 
                ? item.Result.Value.ToString(CultureInfo.InvariantCulture)
                : "null";

            string queryString = item.Id > 0
                ? "UPDATE * FROM [dbo].[History]"
                : "INSERT INTO [dbo].[History] ([Operation], [Args], [Result], [ExecDate])" +
                $" VALUES (N'{item.Operation}', N'{item.Args}', {doubleResult}, N'{item.ExecDate}') ";

            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand(queryString, connection);
                connection.Open();

                var count = command.ExecuteNonQuery();
            }*/
        }

        #region Работа с БД

        private IEnumerable<IHistoryItem> ReadData()
        {
            var items = new List<IHistoryItem>();

            string queryString = "SELECT * FROM [dbo].[History]";

            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand(queryString, connection);
                connection.Open();

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    items.Add(ReadSingleRow(reader));
                }

                reader.Close();
            }

            return items;
        }

        private IHistoryItem ReadSingleRow(IDataRecord record)
        {
            var item = new HistoryItem();

            item.Id = (long)record["Id"];
            item.Operation = (long)record["Operation"];
            item.Args = (string)record["Args"];

            var ind = record.GetOrdinal("Result");
            var isnull = record.IsDBNull(ind);
            if (!isnull)
            {
                item.Result = (double?)record["Result"];
            }

            item.ExecDate = (DateTime)record["ExecDate"];

            return item;
        }

        #endregion
    }
}
