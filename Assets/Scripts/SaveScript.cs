using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SaveScript
{
    public static readonly string saveFolder = Application.dataPath + "/Saves/";
    public static FileInfo[] saveFiles;

    public static void InitSaveFolder()
    {
        if (!Directory.Exists(saveFolder))
        {
            Directory.CreateDirectory(saveFolder);
        }
    }

    public static void Save(string saveString)
    {
        InitSaveFolder();

        int saveNumber = 1;
        while (File.Exists(saveFolder + "saveFile_" + saveNumber + ".json"))
        {
            saveNumber++;
        }

        File.WriteAllText(saveFolder + "saveFile_" + saveNumber + ".json", saveString);
    }

    public static void Load()
    {
        DirectoryInfo directory = new DirectoryInfo(saveFolder);
        saveFiles = directory.GetFiles("*.json");
    }
}
