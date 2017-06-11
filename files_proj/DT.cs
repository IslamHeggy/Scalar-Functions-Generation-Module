using System.IO;
using System.Xml;

namespace files_proj
{
    public  class DT
    {
        public void get_dt()
        {

   
            if (!File.Exists("Dt.xml"))
            { 
                XmlWriter wrt = XmlWriter.Create("Dt.xml");
                wrt.WriteStartDocument();

                wrt.WriteStartElement("datatypes");



                wrt.WriteStartElement("Sum");
                wrt.WriteAttributeString("dt", "int");
                wrt.WriteEndElement();

                wrt.WriteStartElement("Avg");
                wrt.WriteAttributeString("dt", "int");
                wrt.WriteEndElement();


                wrt.WriteEndElement();
                wrt.WriteEndDocument();

                wrt.Close();
          }

            else
            {
                XmlDocument doc = new XmlDocument();

                doc.Load("Dt.xml");

           /*   XmlElement Dt = doc.CreateElement("datatypes");
                XmlElement node = doc.CreateElement("ID");
                node.SetAttribute("dt", "int");
                Dt.AppendChild(node);


                node = doc.CreateElement("Name");
                node.SetAttribute("dt", "string");
                Dt.AppendChild(node);

                node = doc.CreateElement("Salary");
                node.SetAttribute("dt", "int");
                Dt.AppendChild(node);

                XmlElement root = doc.DocumentElement;
                root.AppendChild(Dt);
             */

                doc.Save("Dt.xml");
            }
        }
    }
}
