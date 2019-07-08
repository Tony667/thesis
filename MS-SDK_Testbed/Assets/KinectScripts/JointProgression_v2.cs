using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class JointProgression_v2 
{
    public string expertMovement;
    public string[] expertMovementContents;
    public string[] expertMovementFields;// do i need this?
    public int expertMovementNumberOfLines;

    public string amatureMovement;
    public string[] amatureMovementContents;
    public string[] amatureMovementFields;
    public int amatureMovementNumberOfLines;

    public Dictionary<string, List<double>> expertJoint = new Dictionary<string, List<double>>();

    public JointProgression_v2()
    {
        if (File.Exists(Application.dataPath + "/MovementDataBase/" + expertMovement + ".csv"))
        {
            expertMovementContents = File.ReadAllLines(Application.dataPath + "/MovementDataBase/" + expertMovement + ".csv");
            expertMovementNumberOfLines = expertMovementContents.Length;
            for (int i = 1; i < expertMovementNumberOfLines; i++)
            {
                expertMovementFields = expertMovementContents[i].Split(';');
                for(int j = 0; j <= 56; j++)
                {
                    switch (j)
                    {
                        case 1:
                            //expertJoint.Add("expertJoint" + j, new List<double>(double.Parse(expertMovementFields[3])));
                            //expertJoint.Add(new KeyValuePair<string, double>("expertJoint" + j, double.Parse(expertMovementFields[3])));
                            break;
                    }
                }
            }
        }
        if (File.Exists(Application.dataPath + "/MovementDataBase/" + amatureMovement + ".csv"))
        {
            amatureMovementContents = File.ReadAllLines(Application.dataPath + "/MovementDataBase/" + amatureMovement + ".csv");
            amatureMovementNumberOfLines = amatureMovementContents.Length;
            for (int j = 1; j < amatureMovementNumberOfLines; j++)
            {
                amatureMovementFields = amatureMovementContents[j].Split(';');
            }
        }
    }
}
