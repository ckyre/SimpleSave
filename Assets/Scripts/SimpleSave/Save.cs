using System.IO;
using UnityEngine;

namespace SimpleSave
{
    public static class Constants
    {
        public const string SupportedDocumentVersion = "v1.0.0";
    }
    
    public class Save<DataType> where DataType: SaveData, new()
    {
        private DataType _data;
        
        public Save()
        {
            _data = new DataType();
        }
        
        public Save(string filename)
        {
            LoadFromFile(filename);
        }

        public DataType GetData()
        {
            return _data;
        }
        
        public void WriteToFile(string filename)
        {
            File.WriteAllText(filename, JsonUtility.ToJson(_data, true));
        }

        public void LoadFromFile(string filename)
        {
            _data = JsonUtility.FromJson<DataType>(File.ReadAllText(filename));
        }
        
    }
}
