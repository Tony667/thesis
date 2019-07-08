using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public static class MovementDataBasePathCheck
{
    // the directory that will be used as databese
    public static readonly string pathExpert = Application.dataPath + "/MovementDataBase" + "/" + "ExpertMovement";
    public static readonly string pathAmature = Application.dataPath + "/MovementDataBase" + "/" + "AmatureMovement";

    public static void Init()
    {
        //test if folder exist
        if (!Directory.Exists(pathExpert))
        {
            // create folder if it doen't exist
            Directory.CreateDirectory(pathExpert);
        }

        if (!Directory.Exists(pathAmature))
        {
            Directory.CreateDirectory(pathAmature);
        }
    }
}
