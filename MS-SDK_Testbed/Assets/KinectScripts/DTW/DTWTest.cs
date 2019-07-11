using System.Collections;
using System.Collections.Generic;
using System.IO; 
using UnityEngine;
using DTW;

public class DTWTest : MonoBehaviour
{
    //public string expertMovement;
    public string[] expertMovementContents;
    public string[] expertMovementFields;// do i need this?
    public int expertMovementNumberOfLines;

    //public string amatureMovement;
    public string[] amatureMovementContents;
    public string[] amatureMovementFields;
    public int amatureMovementNumberOfLines;

    public string movementToLoad;

    public bool compare;

    JointProgression jointProgression = new JointProgression();
    SimpleDTW simpleDTW;

    void Start()
    {
        //LoadingSystem loadingSystem = GetComponent<LoadingSystem>();
        //movementToLoad = loadingSystem.movementToLoad;

        if (File.Exists(/*MovementDataBasePathCheck.pathExpert +*/Application.dataPath + "/MovementDataBase/" + "ExpertMovement/" + movementToLoad + ".csv"))
        {
            Debug.Log("file exists");
            expertMovementContents = File.ReadAllLines(Application.dataPath + "/MovementDataBase/" + "ExpertMovement/" + movementToLoad + ".csv");
            expertMovementNumberOfLines = expertMovementContents.Length;
            for (int i = 1; i < expertMovementNumberOfLines; i++)
            {
                expertMovementFields = expertMovementContents[i].Split(';');
                jointProgression.expertJoint0X.Add(double.Parse(expertMovementFields[3]));
                jointProgression.expertJoint0Y.Add(double.Parse(expertMovementFields[4]));
                jointProgression.expertJoint0Z.Add(double.Parse(expertMovementFields[5]));
                jointProgression.expertJoint1X.Add(double.Parse(expertMovementFields[7]));
                jointProgression.expertJoint1Y.Add(double.Parse(expertMovementFields[8]));
                jointProgression.expertJoint1Z.Add(double.Parse(expertMovementFields[9]));
                jointProgression.expertJoint2X.Add(double.Parse(expertMovementFields[11]));
                jointProgression.expertJoint2Y.Add(double.Parse(expertMovementFields[12]));
                jointProgression.expertJoint2Z.Add(double.Parse(expertMovementFields[13]));
                jointProgression.expertJoint3X.Add(double.Parse(expertMovementFields[15]));
                jointProgression.expertJoint3Y.Add(double.Parse(expertMovementFields[16]));
                jointProgression.expertJoint3Z.Add(double.Parse(expertMovementFields[17]));
                jointProgression.expertJoint4X.Add(double.Parse(expertMovementFields[19]));
                jointProgression.expertJoint4Y.Add(double.Parse(expertMovementFields[20]));
                jointProgression.expertJoint4Z.Add(double.Parse(expertMovementFields[21]));
                jointProgression.expertJoint5X.Add(double.Parse(expertMovementFields[23]));
                jointProgression.expertJoint5Y.Add(double.Parse(expertMovementFields[24]));
                jointProgression.expertJoint5Z.Add(double.Parse(expertMovementFields[25]));
                jointProgression.expertJoint6X.Add(double.Parse(expertMovementFields[27]));
                jointProgression.expertJoint6Y.Add(double.Parse(expertMovementFields[28]));
                jointProgression.expertJoint6Z.Add(double.Parse(expertMovementFields[29]));
                jointProgression.expertJoint7X.Add(double.Parse(expertMovementFields[31]));
                jointProgression.expertJoint7Y.Add(double.Parse(expertMovementFields[32]));
                jointProgression.expertJoint7Z.Add(double.Parse(expertMovementFields[33]));
                jointProgression.expertJoint8X.Add(double.Parse(expertMovementFields[35]));
                jointProgression.expertJoint8Y.Add(double.Parse(expertMovementFields[36]));
                jointProgression.expertJoint8Z.Add(double.Parse(expertMovementFields[37]));
                jointProgression.expertJoint9X.Add(double.Parse(expertMovementFields[39]));
                jointProgression.expertJoint9Y.Add(double.Parse(expertMovementFields[40]));
                jointProgression.expertJoint9Z.Add(double.Parse(expertMovementFields[41]));
                jointProgression.expertJoint10X.Add(double.Parse(expertMovementFields[43]));
                jointProgression.expertJoint10Y.Add(double.Parse(expertMovementFields[44]));
                jointProgression.expertJoint10Z.Add(double.Parse(expertMovementFields[45]));
                jointProgression.expertJoint11X.Add(double.Parse(expertMovementFields[47]));
                jointProgression.expertJoint11Y.Add(double.Parse(expertMovementFields[48]));
                jointProgression.expertJoint11Z.Add(double.Parse(expertMovementFields[49]));
                jointProgression.expertJoint12X.Add(double.Parse(expertMovementFields[51]));
                jointProgression.expertJoint12Y.Add(double.Parse(expertMovementFields[52]));
                jointProgression.expertJoint12Z.Add(double.Parse(expertMovementFields[53]));
                jointProgression.expertJoint13X.Add(double.Parse(expertMovementFields[55]));
                jointProgression.expertJoint13Y.Add(double.Parse(expertMovementFields[56]));
                jointProgression.expertJoint13Z.Add(double.Parse(expertMovementFields[57]));
                jointProgression.expertJoint14X.Add(double.Parse(expertMovementFields[59]));
                jointProgression.expertJoint14Y.Add(double.Parse(expertMovementFields[60]));
                jointProgression.expertJoint14Z.Add(double.Parse(expertMovementFields[61]));
                jointProgression.expertJoint15X.Add(double.Parse(expertMovementFields[63]));
                jointProgression.expertJoint15Y.Add(double.Parse(expertMovementFields[64]));
                jointProgression.expertJoint15Z.Add(double.Parse(expertMovementFields[65]));
                jointProgression.expertJoint16X.Add(double.Parse(expertMovementFields[67]));
                jointProgression.expertJoint16Y.Add(double.Parse(expertMovementFields[68]));
                jointProgression.expertJoint16Z.Add(double.Parse(expertMovementFields[69]));
                jointProgression.expertJoint17X.Add(double.Parse(expertMovementFields[71]));
                jointProgression.expertJoint17Y.Add(double.Parse(expertMovementFields[72]));
                jointProgression.expertJoint17Z.Add(double.Parse(expertMovementFields[73]));
                jointProgression.expertJoint18X.Add(double.Parse(expertMovementFields[75]));
                jointProgression.expertJoint18Y.Add(double.Parse(expertMovementFields[76]));
                jointProgression.expertJoint18Z.Add(double.Parse(expertMovementFields[77]));
                jointProgression.expertJoint19X.Add(double.Parse(expertMovementFields[79]));
                jointProgression.expertJoint19Y.Add(double.Parse(expertMovementFields[80]));
                jointProgression.expertJoint19Z.Add(double.Parse(expertMovementFields[81]));
            }
        }
        if (File.Exists(Application.dataPath + "/MovementDataBase/" + "ExpertMovement/" + movementToLoad + ".csv"))
        {
            amatureMovementContents = File.ReadAllLines(/*MovementDataBasePathCheck.pathAmature +*/Application.dataPath + "/MovementDataBase/" + "ExpertMovement/" + movementToLoad + ".csv");
            amatureMovementNumberOfLines = amatureMovementContents.Length;
            for (int j = 1; j < amatureMovementNumberOfLines; j++)
            {
                amatureMovementFields = amatureMovementContents[j].Split(';');
                jointProgression.amatureJoint0X.Add(double.Parse(expertMovementFields[3]));
                jointProgression.amatureJoint0Y.Add(double.Parse(expertMovementFields[4]));
                jointProgression.amatureJoint0Z.Add(double.Parse(expertMovementFields[5]));
                jointProgression.amatureJoint1X.Add(double.Parse(expertMovementFields[7]));
                jointProgression.amatureJoint1Y.Add(double.Parse(expertMovementFields[8]));
                jointProgression.amatureJoint1Z.Add(double.Parse(expertMovementFields[9]));
                jointProgression.amatureJoint2X.Add(double.Parse(expertMovementFields[11]));
                jointProgression.amatureJoint2Y.Add(double.Parse(expertMovementFields[12]));
                jointProgression.amatureJoint2Z.Add(double.Parse(expertMovementFields[13]));
                jointProgression.amatureJoint3X.Add(double.Parse(expertMovementFields[15]));
                jointProgression.amatureJoint3Y.Add(double.Parse(expertMovementFields[16]));
                jointProgression.amatureJoint3Z.Add(double.Parse(expertMovementFields[17]));
                jointProgression.amatureJoint4X.Add(double.Parse(expertMovementFields[19]));
                jointProgression.amatureJoint4Y.Add(double.Parse(expertMovementFields[20]));
                jointProgression.amatureJoint4Z.Add(double.Parse(expertMovementFields[21]));
                jointProgression.amatureJoint5X.Add(double.Parse(expertMovementFields[23]));
                jointProgression.amatureJoint5Y.Add(double.Parse(expertMovementFields[24]));
                jointProgression.amatureJoint5Z.Add(double.Parse(expertMovementFields[25]));
                jointProgression.amatureJoint6X.Add(double.Parse(expertMovementFields[27]));
                jointProgression.amatureJoint6Y.Add(double.Parse(expertMovementFields[28]));
                jointProgression.amatureJoint6Z.Add(double.Parse(expertMovementFields[29]));
                jointProgression.amatureJoint7X.Add(double.Parse(expertMovementFields[31]));
                jointProgression.amatureJoint7Y.Add(double.Parse(expertMovementFields[32]));
                jointProgression.amatureJoint7Z.Add(double.Parse(expertMovementFields[33]));
                jointProgression.amatureJoint8X.Add(double.Parse(expertMovementFields[35]));
                jointProgression.amatureJoint8Y.Add(double.Parse(expertMovementFields[36]));
                jointProgression.amatureJoint8Z.Add(double.Parse(expertMovementFields[37]));
                jointProgression.amatureJoint9X.Add(double.Parse(expertMovementFields[39]));
                jointProgression.amatureJoint9Y.Add(double.Parse(expertMovementFields[40]));
                jointProgression.amatureJoint9Z.Add(double.Parse(expertMovementFields[41]));
                jointProgression.amatureJoint10X.Add(double.Parse(expertMovementFields[43]));
                jointProgression.amatureJoint10Y.Add(double.Parse(expertMovementFields[44]));
                jointProgression.amatureJoint10Z.Add(double.Parse(expertMovementFields[45]));
                jointProgression.amatureJoint11X.Add(double.Parse(expertMovementFields[47]));
                jointProgression.amatureJoint11Y.Add(double.Parse(expertMovementFields[48]));
                jointProgression.amatureJoint11Z.Add(double.Parse(expertMovementFields[49]));
                jointProgression.amatureJoint12X.Add(double.Parse(expertMovementFields[51]));
                jointProgression.amatureJoint12Y.Add(double.Parse(expertMovementFields[52]));
                jointProgression.amatureJoint12Z.Add(double.Parse(expertMovementFields[53]));
                jointProgression.amatureJoint13X.Add(double.Parse(expertMovementFields[55]));
                jointProgression.amatureJoint13Y.Add(double.Parse(expertMovementFields[56]));
                jointProgression.amatureJoint13Z.Add(double.Parse(expertMovementFields[57]));
                jointProgression.amatureJoint14X.Add(double.Parse(expertMovementFields[59]));
                jointProgression.amatureJoint14Y.Add(double.Parse(expertMovementFields[60]));
                jointProgression.amatureJoint14Z.Add(double.Parse(expertMovementFields[61]));
                jointProgression.amatureJoint15X.Add(double.Parse(expertMovementFields[63]));
                jointProgression.amatureJoint15Y.Add(double.Parse(expertMovementFields[64]));
                jointProgression.amatureJoint15Z.Add(double.Parse(expertMovementFields[65]));
                jointProgression.amatureJoint16X.Add(double.Parse(expertMovementFields[67]));
                jointProgression.amatureJoint16Y.Add(double.Parse(expertMovementFields[68]));
                jointProgression.amatureJoint16Z.Add(double.Parse(expertMovementFields[69]));
                jointProgression.amatureJoint17X.Add(double.Parse(expertMovementFields[71]));
                jointProgression.amatureJoint17Y.Add(double.Parse(expertMovementFields[72]));
                jointProgression.amatureJoint17Z.Add(double.Parse(expertMovementFields[73]));
                jointProgression.amatureJoint18X.Add(double.Parse(expertMovementFields[75]));
                jointProgression.amatureJoint18Y.Add(double.Parse(expertMovementFields[76]));
                jointProgression.amatureJoint18Z.Add(double.Parse(expertMovementFields[77]));
                jointProgression.amatureJoint19X.Add(double.Parse(expertMovementFields[79]));
                jointProgression.amatureJoint19Y.Add(double.Parse(expertMovementFields[80]));
                jointProgression.amatureJoint19Z.Add(double.Parse(expertMovementFields[81]));
            }
        }

        //SimpleDTW simpleDTW = new SimpleDTW(double.Parse(expertMovementFields), double.Parse(amatureMovementFields));

        //SimpleDTW.x = double.Parse(expertMovementFields);
        //SimpleDTW.y = double.Parse(amatureMovementFields);
        //simpleDTW.computeDTW(); 

        Debug.Log("in compare");
        jointProgression.JointProgressionExpert();
        jointProgression.JointProgressionAmature();

        jointProgression.ExpertArrays();
        jointProgression.AmatureArrays();

        Debug.Log(jointProgression.amatureMovementFootRightZ);

        for (int i = 0; i <= jointProgression.expertArrays.Count; i++)
        {
            Debug.Log(jointProgression.expertArrays[4].Length);
            Debug.Log(jointProgression.amatureArrays[4].Length);
            Debug.Log(jointProgression.expertArrays[4][125]);
            Debug.Log(jointProgression.amatureArrays[4][125]);
            simpleDTW = new SimpleDTW(jointProgression.expertArrays[i], jointProgression.amatureArrays[i]);
            simpleDTW.computeDTW();
            Debug.Log("SUM = " + simpleDTW.getSum());
        }
    }

    //private void Update()
    //{
    //    if (compare)
    //    {

    //    }
    //}
}
