using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Windows.Forms;
using QueryExecutor;

namespace Utils
{
    public class Cifrado
    {
        public static string MD5(string input)
        {
            // step 1, calculate MD5 hash from input
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);
            // step 2, convert byte array to hex string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }
    }

    public static class Controlador
    {
        public static void MostrarEnDataGridView(QueryResult query, DataGridView dgv, int fillColumn, int[] hideColumns)
        {
            if (hideColumns == null)
            {
                hideColumns = new int[0];
            }
            // Se agregan las columnas
            dgv.Columns.Clear();
            for (int c = 0; c < query.ColumnCount; c++)
            {
                dgv.Columns.Add(string.Format("col{0}", query.Columns[c].Name), query.Columns[c].Name);
                dgv.Columns[c].AutoSizeMode = (c == fillColumn) ? DataGridViewAutoSizeColumnMode.Fill : DataGridViewAutoSizeColumnMode.AllCells;
                if (hideColumns.Contains(c))
                {
                    dgv.Columns[c].Visible = false;
                }
            }

            // Se muestran los datos
            for (int r = 0; r < query.RowCount; r++)
            {
                List<object> campos = new List<object>();
                for (int c = 0; c < query.ColumnCount; c++)
                {
                    campos.Add(query[r][query.Columns[c].Name].Value);
                }
                dgv.Rows.Add(campos.ToArray());
            }
        }
    }
}
