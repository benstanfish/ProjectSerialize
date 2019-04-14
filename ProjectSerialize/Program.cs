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

            AThing thing = new AThing();
            thing.ID = 1;
            thing.FirstName = "Ben";
            thing.LastName = "Fisher";
            thing.FavoriteInteger = 39;

            thing.SaveObject(@"C:\Users\benst\Desktop\Project Serialize\XML_Serialize");

            AThing newThing = AThing.LoadFromFile(@"C:\Users\benst\Desktop\Project Serialize\XML_Serialize");
            // MessageBox.Show(newThing.FirstName.ToString());

        }

    }

    [Serializable]
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
            using (FileStream stream = new FileStream(fileName, FileMode.Create))
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

}
