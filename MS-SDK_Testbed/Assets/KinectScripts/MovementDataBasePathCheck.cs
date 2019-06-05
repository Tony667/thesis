using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public static class MovementDataBasePathCheck
{
    // the directory that will be used as databese
    public static readonly string MovementDataBase = Application.dataPath + "/MovementDataBase/";

    public static void Init()
    {
        //test if folder exist
        if (!Directory.Exists(Application.dataPath + "/MovementDataBase/"))
        {
            // create folder if it doen't exist
            Directory.CreateDirectory(Application.dataPath + "/MovementDataBase/");
        }
    }
}
