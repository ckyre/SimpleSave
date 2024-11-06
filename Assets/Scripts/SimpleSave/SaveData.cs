using System;
using UnityEngine;

namespace SimpleSave
{
    [Serializable]
    public class SaveData
    {
        public string docVersion;
        public string appVersion;

        public SaveData()
        {
            docVersion = SimpleSave.Constants.SupportedDocumentVersion;
            appVersion = Application.version;
        }
    }
}
