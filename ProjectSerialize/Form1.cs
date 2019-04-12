using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProjectSerialize
{

    public partial class FormSerialize : Form
    {


        public FormSerialize()
        {
            InitializeComponent();

            string projectDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+ "\\Project Serialize\\";
            Directory.CreateDirectory(projectDirectory);
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dataGridView1.Rows[e.RowIndex].Cells["id"].Value = (e.RowIndex + 1).ToString();
        }

        private void ButtonWrite_Click(object sender, EventArgs e)
        {
            string usersDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            TextWriter writer = new StreamWriter(usersDesktop + "\\Project Serialize\\Log_" + DateTime.Now.ToString("yyyyMMddhhmmss") + ".txt");

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    if (j == dataGridView1.Columns.Count - 1)
                    {
                        writer.Write(dataGridView1.Rows[i].Cells[j].Value.ToString());
                    }
                    else
                    {
                        writer.Write(dataGridView1.Rows[i].Cells[j].Value.ToString() + "\t");
                    }  
                }
                
                writer.WriteLine();
            }
            writer.Close();
            MessageBox.Show("Data export complete.");
        }

        

        private void ButtonRead_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog fd = new OpenFileDialog())
            {
                string usersDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                fd.InitialDirectory = usersDesktop + "\\Project Serialize\\";
                fd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                fd.FilterIndex = 2;
                fd.RestoreDirectory = true;

                /*
                if (fd.ShowDialog() == DialogResult.OK)
                {
                    filePath = fd.FileName;
                    var fileStream = fd.OpenFile();
                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                    MessageBox.Show("File read without errors.");
                }
                */

                if (fd.ShowDialog() == DialogResult.OK)
                {
                    DataTable dataTable = new DataTable();
                    DataColumn column = new DataColumn();
                    dataTable.Columns.Add(new DataColumn("ID", typeof(int)));
                    dataTable.Columns.Add(new DataColumn("FirstName", typeof(string)));
                    dataTable.Columns.Add(new DataColumn("LastName", typeof(string)));
                    dataTable.Columns.Add(new DataColumn("Age", typeof(string)));

                    filePath = fd.FileName;

                    var lines = File.ReadAllLines(filePath);
                    foreach (string line in lines)
                    {
                        string[] curr = line.Split('\t');
                        var row = dataTable.NewRow();
                        row["id"] = curr[0];
                        row["FirstName"] = curr[1];
                        row["LastName"] = curr[2];
                        row["Age"] = curr[3];
                        dataTable.Rows.Add(row);
                    }

                    this.dataGridView1.Columns.Clear();
                    this.dataGridView1.DataSource = dataTable;
                    MessageBox.Show("File read without errors.");
                }

            }
                
        }
    }
}
