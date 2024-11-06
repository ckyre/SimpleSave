using NUnit.Framework;
using UnityEngine;

public class SaveTest
{
    [Test]
    public void SimpleSaveTest()
    {
        SimpleSave.Save<SimpleSave.PlayerDataExample> myFirstSave = new SimpleSave.Save<SimpleSave.PlayerDataExample>();
        myFirstSave.GetData().health = 10.0f;
        myFirstSave.GetData().name = "another_name";
        myFirstSave.WriteToFile("save.json");
        
        SimpleSave.Save<SimpleSave.PlayerDataExample> mySecondSave = new SimpleSave.Save<SimpleSave.PlayerDataExample>("save.json");
        Assert.AreEqual(mySecondSave.GetData().health, 10.0f);
        Assert.AreEqual(mySecondSave.GetData().name, "another_name");
        Assert.AreEqual(mySecondSave.GetData().appVersion, Application.version);
    }
}
