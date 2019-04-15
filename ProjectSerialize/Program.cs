using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Xml.Serialization;
using System.IO;



namespace ProjectSerialize
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormSerialize());

            CreateProgramDirectory();

            /*
            Random rand = new Random();

            for (int i = 1; i < 101; i++)
            {
                AThing thing = new AThing();
                thing.ID = i;
                thing.FirstName = RandomText.RandomString();
                thing.LastName = RandomText.RandomString();
                thing.FavoriteInteger = rand.Next();

                thing.SaveObject(@"C:\Users\benst\Desktop\Project Serialize\XML_Serialize");
            }

            // AThing newThing = AThing.LoadFromFile(@"C:\Users\benst\Desktop\Project Serialize\XML_Serialize");
            // MessageBox.Show(newThing.FirstName.ToString());
            */

            // The next bit of code serializes a list of AThing objects

            Random rand = new Random();
            List<AThing> myThings = new List<AThing>();

            for (int i = 1; i < 11; i++)
            {
                AThing thing = new AThing();
                thing.ID = i;
                thing.FirstName = RandomText.RandomString();
                thing.LastName = RandomText.RandomString();
                thing.FavoriteInteger = rand.Next();

                myThings.Add(thing);
            }

            string usersDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string fileName = usersDesktop + @"\Project Serialize\XML_Serialize_List";
            using (FileStream stream = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<AThing>));
                xml.Serialize(stream, myThings);
            }


            /*
            List<AThing> newThingsGroup = new List<AThing>();
            MessageBox.Show(newThingsGroup.Count.ToString());   // Verify that there is nothing in the list

            string fileName = @"C:\Users\benst\Desktop\Project Serialize\XML_Serialize_List";
            using (FileStream stream = new FileStream(fileName, FileMode.Open))
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<AThing>));
                newThingsGroup = (List<AThing>)xml.Deserialize(stream);
            }

            MessageBox.Show(newThingsGroup.Count.ToString());   //Verify that the AThing objects have been properly deserialized
            */

            
        }


        // Utility Methods
        public static void CreateProgramDirectory()
        {
            string projectDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Project Serialize\";
            Directory.CreateDirectory(projectDirectory);
        }


    }




    // [Serializable]   // This directive is only required for non-XML serialization
    public class AThing
    {
        [XmlAttribute]
        public int ID { get; set; }
        [XmlElement]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int FavoriteInteger { get; set; }

        public void SaveObject(string fileName)
        {
            using (FileStream stream = new FileStream(fileName, FileMode.Append))
            {
                XmlSerializer xml = new XmlSerializer(typeof(AThing));
                xml.Serialize(stream, this);
            }
        }

        public static AThing LoadFromFile(string fileName)
        {
            using (FileStream stream = new FileStream(fileName, FileMode.Open))
            {
                XmlSerializer xml = new XmlSerializer(typeof(AThing));
                return (AThing)xml.Deserialize(stream);
            }
        }

    }
    public static class RandomText
    {
        public static string RandomString()
        {
            string path = Path.GetRandomFileName();
            path = path.Replace(".", "");
            return path;
        }
    }
}
