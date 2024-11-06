using System;

namespace SimpleSave
{
    [Serializable]
    public class PlayerDataExample : SaveData
    {
        public float health = 100.0f;
        public string name = "my_player";
        public int index = 4;
    }
}
