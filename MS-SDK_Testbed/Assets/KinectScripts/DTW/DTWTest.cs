﻿using System.Collections;
using System.Collections.Generic;
using System.IO; 
using UnityEngine;
using UnityEngine.UI;
using DTW;
using TMPro;

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

    public string expertMovementToLoad;
    public string amatureFileToLoad;
    public string amatureMovementToLoad;

    private string text;
    private TextMeshProUGUI jointScores;
    private TextMeshProUGUI titleText;


    public bool compare;

    JointProgression jointProgression = new JointProgression();
    CalculateJointAverage calculateJointAverage = new CalculateJointAverage();
    SimpleDTW simpleDTW;

    void Start()
    {
        //LoadingSystem loadingSystem = GetComponent<LoadingSystem>();
        //movementToLoad = loadingSystem.movementToLoad;
        Debug.Log("DTWTest Start");
        titleText = GameObject.Find("Title").GetComponent<TextMeshProUGUI>();
        jointScores = GameObject.Find("Board").GetComponent<TextMeshProUGUI>();

        if (File.Exists(Application.dataPath + "/MovementDataBase/" + "ExpertMovement/" + "Movements/" + expertMovementToLoad + ".csv"))
        {
            Debug.Log("file exists");
            expertMovementContents = File.ReadAllLines(Application.dataPath + "/MovementDataBase/" + "ExpertMovement/" + "Movements/" + expertMovementToLoad + ".csv");
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

        if (File.Exists(Application.dataPath + "/MovementDataBase/" + "AmatureMovement/" + amatureFileToLoad + "/" + amatureMovementToLoad + ".csv"))
        {
            amatureMovementContents = File.ReadAllLines(Application.dataPath + "/MovementDataBase/" + "AmatureMovement/" + amatureFileToLoad + "/" + amatureMovementToLoad + ".csv");
            amatureMovementNumberOfLines = amatureMovementContents.Length;
            for (int j = 1; j < amatureMovementNumberOfLines; j++)
            {
                amatureMovementFields = amatureMovementContents[j].Split(';');

                jointProgression.amatureJoint0X.Add(double.Parse(amatureMovementFields[3]));
                jointProgression.amatureJoint0Y.Add(double.Parse(amatureMovementFields[4]));
                jointProgression.amatureJoint0Z.Add(double.Parse(amatureMovementFields[5]));

                jointProgression.amatureJoint1X.Add(double.Parse(amatureMovementFields[7]));
                jointProgression.amatureJoint1Y.Add(double.Parse(amatureMovementFields[8]));
                jointProgression.amatureJoint1Z.Add(double.Parse(amatureMovementFields[9]));

                jointProgression.amatureJoint2X.Add(double.Parse(amatureMovementFields[11]));
                jointProgression.amatureJoint2Y.Add(double.Parse(amatureMovementFields[12]));
                jointProgression.amatureJoint2Z.Add(double.Parse(amatureMovementFields[13]));

                jointProgression.amatureJoint3X.Add(double.Parse(amatureMovementFields[15]));
                jointProgression.amatureJoint3Y.Add(double.Parse(amatureMovementFields[16]));
                jointProgression.amatureJoint3Z.Add(double.Parse(amatureMovementFields[17]));

                jointProgression.amatureJoint4X.Add(double.Parse(amatureMovementFields[19]));
                jointProgression.amatureJoint4Y.Add(double.Parse(amatureMovementFields[20]));
                jointProgression.amatureJoint4Z.Add(double.Parse(amatureMovementFields[21]));

                jointProgression.amatureJoint5X.Add(double.Parse(amatureMovementFields[23]));
                jointProgression.amatureJoint5Y.Add(double.Parse(amatureMovementFields[24]));
                jointProgression.amatureJoint5Z.Add(double.Parse(amatureMovementFields[25]));

                jointProgression.amatureJoint6X.Add(double.Parse(amatureMovementFields[27]));
                jointProgression.amatureJoint6Y.Add(double.Parse(amatureMovementFields[28]));
                jointProgression.amatureJoint6Z.Add(double.Parse(amatureMovementFields[29]));

                jointProgression.amatureJoint7X.Add(double.Parse(amatureMovementFields[31]));
                jointProgression.amatureJoint7Y.Add(double.Parse(amatureMovementFields[32]));
                jointProgression.amatureJoint7Z.Add(double.Parse(amatureMovementFields[33]));

                jointProgression.amatureJoint8X.Add(double.Parse(amatureMovementFields[35]));
                jointProgression.amatureJoint8Y.Add(double.Parse(amatureMovementFields[36]));
                jointProgression.amatureJoint8Z.Add(double.Parse(amatureMovementFields[37]));

                jointProgression.amatureJoint9X.Add(double.Parse(amatureMovementFields[39]));
                jointProgression.amatureJoint9Y.Add(double.Parse(amatureMovementFields[40]));
                jointProgression.amatureJoint9Z.Add(double.Parse(amatureMovementFields[41]));

                jointProgression.amatureJoint10X.Add(double.Parse(amatureMovementFields[43]));
                jointProgression.amatureJoint10Y.Add(double.Parse(amatureMovementFields[44]));
                jointProgression.amatureJoint10Z.Add(double.Parse(amatureMovementFields[45]));

                jointProgression.amatureJoint11X.Add(double.Parse(amatureMovementFields[47]));
                jointProgression.amatureJoint11Y.Add(double.Parse(amatureMovementFields[48]));
                jointProgression.amatureJoint11Z.Add(double.Parse(amatureMovementFields[49]));

                jointProgression.amatureJoint12X.Add(double.Parse(amatureMovementFields[51]));
                jointProgression.amatureJoint12Y.Add(double.Parse(amatureMovementFields[52]));
                jointProgression.amatureJoint12Z.Add(double.Parse(amatureMovementFields[53]));

                jointProgression.amatureJoint13X.Add(double.Parse(amatureMovementFields[55]));
                jointProgression.amatureJoint13Y.Add(double.Parse(amatureMovementFields[56]));
                jointProgression.amatureJoint13Z.Add(double.Parse(amatureMovementFields[57]));

                jointProgression.amatureJoint14X.Add(double.Parse(amatureMovementFields[59]));
                jointProgression.amatureJoint14Y.Add(double.Parse(amatureMovementFields[60]));
                jointProgression.amatureJoint14Z.Add(double.Parse(amatureMovementFields[61]));

                jointProgression.amatureJoint15X.Add(double.Parse(amatureMovementFields[63]));
                jointProgression.amatureJoint15Y.Add(double.Parse(amatureMovementFields[64]));
                jointProgression.amatureJoint15Z.Add(double.Parse(amatureMovementFields[65]));

                jointProgression.amatureJoint16X.Add(double.Parse(amatureMovementFields[67]));
                jointProgression.amatureJoint16Y.Add(double.Parse(amatureMovementFields[68]));
                jointProgression.amatureJoint16Z.Add(double.Parse(amatureMovementFields[69]));

                jointProgression.amatureJoint17X.Add(double.Parse(amatureMovementFields[71]));
                jointProgression.amatureJoint17Y.Add(double.Parse(amatureMovementFields[72]));
                jointProgression.amatureJoint17Z.Add(double.Parse(amatureMovementFields[73]));

                jointProgression.amatureJoint18X.Add(double.Parse(amatureMovementFields[75]));
                jointProgression.amatureJoint18Y.Add(double.Parse(amatureMovementFields[76]));
                jointProgression.amatureJoint18Z.Add(double.Parse(amatureMovementFields[77]));

                jointProgression.amatureJoint19X.Add(double.Parse(amatureMovementFields[79]));
                jointProgression.amatureJoint19Y.Add(double.Parse(amatureMovementFields[80]));
                jointProgression.amatureJoint19Z.Add(double.Parse(amatureMovementFields[81]));
            }
        }

        //SimpleDTW simpleDTW = new SimpleDTW(double.Parse(expertMovementFields), double.Parse(amatureMovementFields));

        //SimpleDTW.x = double.Parse(expertMovementFields);
        //SimpleDTW.y = double.Parse(amatureMovementFields);
        //simpleDTW.computeDTW(); 

        //Debug.Log("in compare");
        jointProgression.JointProgressionExpert();
        jointProgression.JointProgressionAmature();

        jointProgression.ExpertArrays();
        jointProgression.AmatureArrays();

        //Debug.Log(jointProgression.amatureMovementFootRightZ);

        for (int i = 0; i < jointProgression.expertArrays.Count && i < jointProgression.amatureArrays.Count; i++)
        {
            //Debug.Log(jointProgression.expertArrays[4].Length);
            //Debug.Log(jointProgression.amatureArrays[4].Length);
            //Debug.Log(jointProgression.expertArrays[4][125]);
            //Debug.Log(jointProgression.amatureArrays[4][125]);
            simpleDTW = new SimpleDTW(jointProgression.expertArrays[i], jointProgression.amatureArrays[i]);
            simpleDTW.computeDTW();
            //for(int j = 0; j <= 82; j++)
            //{
            //    Debug.Log("expert arrays: " + jointProgression.expertArrays[i][j]);
            //    Debug.Log("amature arrays: " + jointProgression.amatureArrays[i][j]);
            //}
            calculateJointAverage.dtwResults.Add(simpleDTW.getSum());
            Debug.Log("SUM = " + simpleDTW.getSum());
        }
        calculateJointAverage.CalculateAverage();
        Debug.Log("some shit " + calculateJointAverage.CalculateAverage());

        if (!Directory.Exists(Application.dataPath + "/MovementDataBase/" + "AmatureMovement/" + amatureFileToLoad + "/" + "Avg/"))
        {
            Directory.CreateDirectory(Application.dataPath + "/MovementDataBase/" + "AmatureMovement/" + amatureFileToLoad + "/" + "Avg/");
        }

        if (!File.Exists(Application.dataPath + "/MovementDataBase/" + "AmatureMovement/" + amatureFileToLoad + "/" + "Avg/" + amatureMovementToLoad + ".txt"))
        {
            using (StreamWriter writer = File.CreateText(Application.dataPath + "/MovementDataBase/" + "AmatureMovement/" + amatureFileToLoad + "/" + "Avg/" + amatureMovementToLoad + "Score" + ".txt"))
            {
                text = string.Format("HipCenterAvg = {0} \nSpineAvg = {1} \nShoulderCenterAvg = {2} \nHeadAvg = {3} \nShoulderLeftAvg = {4} \nElbowLeftAvg = {5} \nWristLeftAvg = {6} \nHandLeftAvg = {7} \nShoulderRightAvg = {8} \nElbowRightAvg = {9} \nWristRightAvg = {10} \nHandRightAvg = {11} \n" +
                    "HipLeftAvg = {12} \nKneeLeftAvg = {13} \nAnckleLeftAvg = {14} \nFootLeftAvg = {15} \nHipRightAvg = {16} \nKneeRightAvg = {17} \nAnckleRightAvg = {18} \nFootRightAvg = {19}",
                    calculateJointAverage.CalculateAverage().Item1, calculateJointAverage.CalculateAverage().Item2, calculateJointAverage.CalculateAverage().Item3, calculateJointAverage.CalculateAverage().Item4, calculateJointAverage.CalculateAverage().Item5,
                    calculateJointAverage.CalculateAverage().Item6, calculateJointAverage.CalculateAverage().Item7, calculateJointAverage.CalculateAverage().Item8, calculateJointAverage.CalculateAverage().Item9, calculateJointAverage.CalculateAverage().Item10,
                    calculateJointAverage.CalculateAverage().Item11, calculateJointAverage.CalculateAverage().Item12, calculateJointAverage.CalculateAverage().Item13, calculateJointAverage.CalculateAverage().Item14, calculateJointAverage.CalculateAverage().Item15,
                    calculateJointAverage.CalculateAverage().Item16, calculateJointAverage.CalculateAverage().Item17, calculateJointAverage.CalculateAverage().Item18, calculateJointAverage.CalculateAverage().Item19, calculateJointAverage.CalculateAverage().Item20);

                writer.WriteLine(text);
            }
        }

        titleText.text = "Your Score";
        jointScores.text = text;

    }
    //private void Update()
    //{
    //    if (compare)
    //    {

    //    }
    //}
}
