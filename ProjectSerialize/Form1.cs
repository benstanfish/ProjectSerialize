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
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml;
using System.Xml.Serialization;


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
            // this.dataGridView1.Rows[e.RowIndex].Cells["id"].Value = (e.RowIndex + 1).ToString();
        }

        private void ButtonWrite_Click(object sender, EventArgs e)
        {
            string usersDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            TextWriter writer = new StreamWriter(usersDesktop + "\\Project Serialize\\Log_" + DateTime.Now.ToString("yyyyMMddhhmmss") + ".txt");

            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
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
                }
                
            }
            
        }



        private void ButtonMakePersons_Click(object sender, EventArgs e)
        {
            var persons = new List<Person>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                Person person = new Person();
                persons.Add(person);
            }

            string usersDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //Stream stream = new FileStream(usersDesktop + "\\Project Serialize\\BIN_" + DateTime.Now.ToString("yyyyMMddhhmmss") + ".txt", FileMode.Create, FileAccess.Write);
            string filePath = usersDesktop + "\\Project Serialize\\XML_" + DateTime.Now.ToString("yyyyMMddhhmmss") + ".txt";


            // IFormatter formatter = new BinaryFormatter();
            //BinaryFormatter formatter = new BinaryFormatter();

            //XmlSerializer formatter = new XmlSerializer(typeof(Person));

            foreach (Person person in persons)
            {
                //formatter.Serialize(stream, person);
                person.Save(filePath);
            }
            //stream.Close();
        }

        [Serializable]
        public class Person
        {
            public int ID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }

            public void Save(string fileName)
            {
                using (FileStream stream = new FileStream(fileName,FileMode.Create,FileAccess.Write))
                {
                    XmlSerializer xml = new XmlSerializer(typeof(Person));
                    xml.Serialize(stream,this);
                }
            }

        }

        private void ButtonDeserialize_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fd = new OpenFileDialog())
            {
                string usersDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                fd.InitialDirectory = usersDesktop + "\\Project Serialize\\";
                fd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                fd.FilterIndex = 2;
                fd.RestoreDirectory = true;


                if (fd.ShowDialog() == DialogResult.OK)
                {


                    IFormatter formatter = new BinaryFormatter();
                    Stream stream = new FileStream(fd.FileName, FileMode.Open, FileAccess.Read);

                    Person newPerson = (Person)formatter.Deserialize(stream);
                    


                    /*
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
                    */
                }

            }
        }

        private void ButtonOpenFolder_Click(object sender, EventArgs e)
        {




        }
    }
}
