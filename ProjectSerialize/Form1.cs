using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectSerialize
{
    public partial class FormSerialize : Form
    {
        public FormSerialize()
        {
            InitializeComponent();
            
        }

        /*
        public static void InitializeDataTable(DataGridView dgv)
        {
            DataTable table = new DataTable("ParentTable");
            DataColumn column;
            DataRow row;

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "ID";
            column.ReadOnly = true;
            column.Unique = true;

            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "ParentItem";
            column.AutoIncrement = false;
            column.Caption = "ParentItem";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);

            DataColumn[] PrimaryKeyColumns = new DataColumn[1];
            PrimaryKeyColumns[0] = table.Columns["ID"];
            table.PrimaryKey = PrimaryKeyColumns;

            DataSet dataset = new DataSet();
            dataset.Tables.Add(table);

            for (int i = 0; i <= 10; i++)
            {
                row = table.NewRow();
                row["ID"] = i;
                row["ParentItem"] = "ParentItem " + i;
                table.Rows.Add(row);

            }

            dgv.DataSource = dataset;

        }
        */

    }
}
