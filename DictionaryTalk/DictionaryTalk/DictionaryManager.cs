using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DictionaryTalk
{
    public class DictionaryManager
    {
        #region properties
        private string filePath = "data.xml";
        private DictionaryItem item;

        public DictionaryItem Item
        {
            get { return item; }
            set { item = value; }
        }
        #endregion


        #region methods

        public DictionaryManager()
        {
            item = (DictionaryItem)DeserializeFromXML(filePath);
        }
        public void LoadDataToComboBox(ComboBox comboBox)
        {
            comboBox.DataSource = item.Items;
        }

        public void Serialize()
        {
            SerializeToXML(item, filePath);
        }

        private void SerializeToXML(object data, string path)
        {
            FileStream filestream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer sr = new XmlSerializer(typeof(DictionaryItem));
            sr.Serialize(filestream, data);
            filestream.Close();
        }

        public object DeserializeFromXML(string path)
        {
            FileStream filestream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer sr = new XmlSerializer(typeof(DictionaryItem));
            object obj = sr.Deserialize(filestream);
            filestream.Close();
            return obj;
        }
        #endregion
    }
}
