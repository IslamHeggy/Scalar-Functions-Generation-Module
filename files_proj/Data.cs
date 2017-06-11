using System.IO;
using System.Xml;

namespace files_proj
{
    public class Data
    {
        public void Get_Data()
        {
            if (!File.Exists("Data.xml"))
            {
                XmlWriter wrt = XmlWriter.Create("Data.xml");
                wrt.WriteStartDocument();
                wrt.WriteStartElement("Data");

                wrt.WriteStartElement("emp");

                wrt.WriteStartElement("ID");
                wrt.WriteValue(1);
                wrt.WriteValue("-");
                wrt.WriteValue("int");
                wrt.WriteEndElement();

                wrt.WriteStartElement("Name");
                wrt.WriteString("Ahmed");
                wrt.WriteValue("-");
                wrt.WriteValue("string");
                wrt.WriteEndElement();

                wrt.WriteStartElement("Gender");
                wrt.WriteValue("Male");
                wrt.WriteValue("-");
                wrt.WriteValue("string");
                wrt.WriteEndElement();

                wrt.WriteStartElement("Salary");
                wrt.WriteValue(100);
                wrt.WriteValue("-");
                wrt.WriteValue("int");
                wrt.WriteEndElement();

                wrt.WriteStartElement("Age");
                wrt.WriteValue(29);
                wrt.WriteValue("-");
                wrt.WriteValue("int");
                wrt.WriteEndElement();

                wrt.WriteEndElement();

                ///////////////////////////////////////////////
                wrt.WriteStartElement("emp");

                wrt.WriteStartElement("ID");
                wrt.WriteValue(2);
                wrt.WriteValue("-");
                wrt.WriteValue("int");
                wrt.WriteEndElement();

                wrt.WriteStartElement("Name");
                wrt.WriteString("Ali");
                wrt.WriteValue("-");
                wrt.WriteValue("string");
                wrt.WriteEndElement();

                wrt.WriteStartElement("Gender");
                wrt.WriteValue("Male");
                wrt.WriteValue("-");
                wrt.WriteValue("string");
                wrt.WriteEndElement();

                wrt.WriteStartElement("Salary");
                wrt.WriteValue(250);
                wrt.WriteValue("-");
                wrt.WriteValue("int");
                wrt.WriteEndElement();

                wrt.WriteStartElement("Age");
                wrt.WriteValue(15);
                wrt.WriteValue("-");
                wrt.WriteValue("int");
                wrt.WriteEndElement();

                wrt.WriteEndElement();

                /////////////////////////////////////////////
                wrt.WriteStartElement("emp");

                wrt.WriteStartElement("ID");
                wrt.WriteValue(3);
                wrt.WriteValue("-");
                wrt.WriteValue("int");
                wrt.WriteEndElement();

                wrt.WriteStartElement("Name");
                wrt.WriteString("Amira");
                wrt.WriteValue("-");
                wrt.WriteValue("string");
                wrt.WriteEndElement();

                wrt.WriteStartElement("Gender");
                wrt.WriteValue("Female");
                wrt.WriteValue("-");
                wrt.WriteValue("string");
                wrt.WriteEndElement();

                wrt.WriteStartElement("Salary");
                wrt.WriteValue(300);
                wrt.WriteValue("-");
                wrt.WriteValue("int");
                wrt.WriteEndElement();

                wrt.WriteStartElement("Age");
                wrt.WriteValue(20);
                wrt.WriteValue("-");
                wrt.WriteValue("int");
                wrt.WriteEndElement();

                wrt.WriteEndElement();

                /////////////////////////////////////////////
                wrt.WriteStartElement("emp");

                wrt.WriteStartElement("ID");
                wrt.WriteValue(4);
                wrt.WriteValue("-");
                wrt.WriteValue("int");
                wrt.WriteEndElement();

                wrt.WriteStartElement("Name");
                wrt.WriteString("Eslam");
                wrt.WriteValue("-");
                wrt.WriteValue("string");
                wrt.WriteEndElement();

                wrt.WriteStartElement("Gender");
                wrt.WriteValue("Male");
                wrt.WriteValue("-");
                wrt.WriteValue("string");
                wrt.WriteEndElement();

                wrt.WriteStartElement("Salary");
                wrt.WriteValue(900);
                wrt.WriteValue("-");
                wrt.WriteValue("int");
                wrt.WriteEndElement();

                wrt.WriteStartElement("Age");
                wrt.WriteValue(12);
                wrt.WriteValue("-");
                wrt.WriteValue("int");
                wrt.WriteEndElement();

                wrt.WriteEndElement();
                ////////////////////////////////////////

                /////////////////////////////////////////////
                wrt.WriteStartElement("student");

                wrt.WriteStartElement("ID");
                wrt.WriteValue(1);
                wrt.WriteValue("-");
                wrt.WriteValue("int");
                wrt.WriteEndElement();

                wrt.WriteStartElement("Name");
                wrt.WriteString("3afaf");
                wrt.WriteValue("-");
                wrt.WriteValue("string");
                wrt.WriteEndElement();

                wrt.WriteStartElement("Gender");
                wrt.WriteValue("Female");
                wrt.WriteValue("-");
                wrt.WriteValue("string");
                wrt.WriteEndElement();

                wrt.WriteStartElement("Age");
                wrt.WriteValue(25);
                wrt.WriteValue("-");
                wrt.WriteValue("int");
                wrt.WriteEndElement();

                wrt.WriteStartElement("Year");
                wrt.WriteValue(2);
                wrt.WriteValue("-");
                wrt.WriteValue("int");
                wrt.WriteEndElement();


                wrt.WriteEndElement();

                /////////////////////////////////////////////
                wrt.WriteStartElement("student");

                wrt.WriteStartElement("ID");
                wrt.WriteValue(2);
                wrt.WriteValue("-");
                wrt.WriteValue("int");
                wrt.WriteEndElement();

                wrt.WriteStartElement("Name");
                wrt.WriteString("Ezz");
                wrt.WriteValue("-");
                wrt.WriteValue("string");
                wrt.WriteEndElement();

                wrt.WriteStartElement("Gender");
                wrt.WriteValue("Male");
                wrt.WriteValue("-");
                wrt.WriteValue("string");
                wrt.WriteEndElement();

                wrt.WriteStartElement("Age");
                wrt.WriteValue(20);
                wrt.WriteValue("-");
                wrt.WriteValue("int");
                wrt.WriteEndElement();

                wrt.WriteStartElement("Year");
                wrt.WriteValue(3);
                wrt.WriteValue("-");
                wrt.WriteValue("int");
                wrt.WriteEndElement();


                wrt.WriteEndElement();

                /////////////////////////////////////////////
                wrt.WriteStartElement("student");

                wrt.WriteStartElement("ID");
                wrt.WriteValue(3);
                wrt.WriteValue("-");
                wrt.WriteValue("int");
                wrt.WriteEndElement();

                wrt.WriteStartElement("Name");
                wrt.WriteString("Mohamed");
                wrt.WriteValue("-");
                wrt.WriteValue("string");
                wrt.WriteEndElement();

                wrt.WriteStartElement("Gender");
                wrt.WriteValue("Male");
                wrt.WriteValue("-");
                wrt.WriteValue("string");
                wrt.WriteEndElement();

                wrt.WriteStartElement("Age");
                wrt.WriteValue(28);
                wrt.WriteValue("-");
                wrt.WriteValue("int");
                wrt.WriteEndElement();

                wrt.WriteStartElement("Year");
                wrt.WriteValue(4);
                wrt.WriteValue("-");
                wrt.WriteValue("int");
                wrt.WriteEndElement();


                wrt.WriteEndElement();
                /////////////////////////////////////////////
                wrt.WriteStartElement("student");

                wrt.WriteStartElement("ID");
                wrt.WriteValue(4);
                wrt.WriteValue("-");
                wrt.WriteValue("int");
                wrt.WriteEndElement();

                wrt.WriteStartElement("Name");
                wrt.WriteString("Wael");
                wrt.WriteValue("-");
                wrt.WriteValue("string");
                wrt.WriteEndElement();

                wrt.WriteStartElement("Gender");
                wrt.WriteValue("Male");
                wrt.WriteValue("-");
                wrt.WriteValue("string");
                wrt.WriteEndElement();

                wrt.WriteStartElement("Age");
                wrt.WriteValue(20);
                wrt.WriteValue("-");
                wrt.WriteValue("int");
                wrt.WriteEndElement();

                wrt.WriteStartElement("Year");
                wrt.WriteValue(3);
                wrt.WriteValue("-");
                wrt.WriteValue("int");
                wrt.WriteEndElement();


                wrt.WriteEndElement();
                ////////////////////////////////////////

                wrt.WriteEndElement();
                wrt.WriteEndDocument();

                wrt.Close();
            }

            else
            {
                XmlDocument doc = new XmlDocument();

                doc.Load("Data.xml");

                doc.Save("Data.xml");
            }
        }
    }
}
