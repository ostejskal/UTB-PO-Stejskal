using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace UTB_PO_Stejskal
{
    public class XMLObject
    {
        
        public AllObjects allObjects;
        public XmlSerializer xmlSerializer;
        private String path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\objects.xml";

        public XMLObject()
        {
            allObjects = new AllObjects();
            xmlSerializer = new XmlSerializer(typeof(AllObjects));
        }



        public void Serialize(AllObjects allObjects)
        {

            using (StreamWriter myWriter = new StreamWriter(path, false))
            {
                this.xmlSerializer.Serialize(myWriter, allObjects);
            }

        }

        public AllObjects DeSerialize()
        {
            if (!File.Exists(this.path))
            {
                return this.allObjects;
            }

            using (StreamReader readtext = new StreamReader(this.path))
            {
                using (XmlReader reader = XmlReader.Create(readtext))
                {
                    this.allObjects = (AllObjects)xmlSerializer.Deserialize(reader);
                }
            }

            return this.allObjects;

        }
    }
}
