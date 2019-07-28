using System.Collections;
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

    public bool compare;

    private string text;
    //private TextMeshProUGUI jointScores;
    private TextMeshProUGUI titleText;
    private TextMeshProUGUI Item1;
    private TextMeshProUGUI Item2;
    private TextMeshProUGUI Item3;
    private TextMeshProUGUI Item4;
    private TextMeshProUGUI Item5;
    private TextMeshProUGUI Item6;
    private TextMeshProUGUI Item7;
    private TextMeshProUGUI Item8;
    private TextMeshProUGUI Item9;
    private TextMeshProUGUI Item10;
    private TextMeshProUGUI Item11;
    private TextMeshProUGUI Item12;
    private TextMeshProUGUI Item13;
    private TextMeshProUGUI Item14;
    private TextMeshProUGUI Item15;
    private TextMeshProUGUI Item16;
    private TextMeshProUGUI Item17;
    private TextMeshProUGUI Item18;
    private TextMeshProUGUI Item19;
    private TextMeshProUGUI Item20;

    private GameObject[] textFields;


    JointProgression jointProgression = new JointProgression();
    CalculateJointAverage calculateJointAverage = new CalculateJointAverage();
    SimpleDTW simpleDTW;

    void Start()
    {
        //LoadingSystem loadingSystem = GetComponent<LoadingSystem>();
        //movementToLoad = loadingSystem.movementToLoad;
        Debug.Log("DTWTest Start");
        titleText = GameObject.Find("Title").GetComponent<TextMeshProUGUI>();
        Item1 = GameObject.Find("Item1").GetComponent<TextMeshProUGUI>();
        Item2 = GameObject.Find("Item2").GetComponent<TextMeshProUGUI>();
        Item3 = GameObject.Find("Item3").GetComponent<TextMeshProUGUI>();
        Item4 = GameObject.Find("Item4").GetComponent<TextMeshProUGUI>();
        Item5 = GameObject.Find("Item5").GetComponent<TextMeshProUGUI>();
        Item6 = GameObject.Find("Item6").GetComponent<TextMeshProUGUI>();
        Item7 = GameObject.Find("Item7").GetComponent<TextMeshProUGUI>();
        Item8 = GameObject.Find("Item8").GetComponent<TextMeshProUGUI>();
        Item9 = GameObject.Find("Item9").GetComponent<TextMeshProUGUI>();
        Item10 = GameObject.Find("Item10").GetComponent<TextMeshProUGUI>();
        Item11 = GameObject.Find("Item11").GetComponent<TextMeshProUGUI>();
        Item12 = GameObject.Find("Item12").GetComponent<TextMeshProUGUI>();
        Item13 = GameObject.Find("Item13").GetComponent<TextMeshProUGUI>();
        Item14 = GameObject.Find("Item14").GetComponent<TextMeshProUGUI>();
        Item15 = GameObject.Find("Item15").GetComponent<TextMeshProUGUI>();
        Item16 = GameObject.Find("Item16").GetComponent<TextMeshProUGUI>();
        Item17 = GameObject.Find("Item17").GetComponent<TextMeshProUGUI>();
        Item18 = GameObject.Find("Item18").GetComponent<TextMeshProUGUI>();
        Item19 = GameObject.Find("Item19").GetComponent<TextMeshProUGUI>();
        Item20 = GameObject.Find("Item20").GetComponent<TextMeshProUGUI>();

        textFields = GameObject.FindGameObjectsWithTag("Text");

        foreach(GameObject textField in textFields)
        {
            textField.gameObject.SetActive(false);
        }
        //jointScores = GameObject.Find("Board").GetComponent<TextMeshProUGUI>();

        if (!Directory.Exists(Application.dataPath + "/MovementDataBase/" + "AmatureMovement/" + amatureFileToLoad + "/" + "Avg/"))
        {
            Directory.CreateDirectory(Application.dataPath + "/MovementDataBase/" + "AmatureMovement/" + amatureFileToLoad + "/" + "Avg/");
        }
    }
    private void Update()
    {
        if (compare)
        {
            if (File.Exists(Application.dataPath + "/MovementDataBase/" + "ExpertMovement/" + "Movements/" + expertMovementToLoad + ".csv"))
            {
                //Debug.Log("file exists");
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


            if (!File.Exists(Application.dataPath + "/MovementDataBase/" + "AmatureMovement/" + amatureFileToLoad + "/" + "Avg/" + amatureMovementToLoad + ".txt"))
            {
                using (StreamWriter writer = File.CreateText(Application.dataPath + "/MovementDataBase/" + "AmatureMovement/" + amatureFileToLoad + "/" + "Avg/" + amatureMovementToLoad + "Score" + ".txt"))
                {
                    text = string.Format("HipCenterAvg = {0:F2} \nSpineAvg = {1:F2} \nShoulderCenterAvg = {2:F2} \nHeadAvg = {3:F2} \nShoulderLeftAvg = {4:F2} \nElbowLeftAvg = {5:F2} \nWristLeftAvg = {6:F2} \nHandLeftAvg = {7:F2} \nShoulderRightAvg = {8:F2} \nElbowRightAvg = {9:F2} \nWristRightAvg = {10:F2} \nHandRightAvg = {11:F2} \n" +
                        "HipLeftAvg = {12:F2} \nKneeLeftAvg = {13:F2} \nAnckleLeftAvg = {14:F2} \nFootLeftAvg = {15:F2} \nHipRightAvg = {16:F2} \nKneeRightAvg = {17:F2} \nAnckleRightAvg = {18:F2} \nFootRightAvg = {19:F2}",
                        calculateJointAverage.CalculateAverage().Item1, calculateJointAverage.CalculateAverage().Item2, calculateJointAverage.CalculateAverage().Item3, calculateJointAverage.CalculateAverage().Item4, calculateJointAverage.CalculateAverage().Item5,
                        calculateJointAverage.CalculateAverage().Item6, calculateJointAverage.CalculateAverage().Item7, calculateJointAverage.CalculateAverage().Item8, calculateJointAverage.CalculateAverage().Item9, calculateJointAverage.CalculateAverage().Item10,
                        calculateJointAverage.CalculateAverage().Item11, calculateJointAverage.CalculateAverage().Item12, calculateJointAverage.CalculateAverage().Item13, calculateJointAverage.CalculateAverage().Item14, calculateJointAverage.CalculateAverage().Item15,
                        calculateJointAverage.CalculateAverage().Item16, calculateJointAverage.CalculateAverage().Item17, calculateJointAverage.CalculateAverage().Item18, calculateJointAverage.CalculateAverage().Item19, calculateJointAverage.CalculateAverage().Item20);
                    //if (calculateJointAverage.CalculateAverage().Item1 > 2.5f)
                    //{
                    //    Item1.color = Color.red;
                    //}
                    writer.WriteLine(text);
                }
            }

            if (expertMovementToLoad.Equals("Movement_01_transform_v2"))
            {
                if(calculateJointAverage.CalculateAverage().Item1 > 16.1f)
                {
                    Item1.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item2 > 15.5f)
                {
                    Item2.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item3 > 15.0f)
                {
                    Item3.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item4 > 14.2f)
                {
                    Item4.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item5 > 16.0f)
                {
                    Item5.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item6 > 17.5f)
                {
                    Item6.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item7 > 16.6f)
                {
                    Item7.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item8 > 16.6f)
                {
                    Item8.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item9 > 10.5f)
                {
                    Item9.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item10 > 12.0f)
                {
                    Item10.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item11 > 11.6f)
                {
                    Item11.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item12 > 11.6f)
                {
                    Item12.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item13 > 17.5f)
                {
                    Item13.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item14 > 14.1f)
                {
                    Item14.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item15 > 16.2f)
                {
                    Item15.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item16 > 15.4f)
                {
                    Item16.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item17 > 14.0f)
                {
                    Item17.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item18 > 9.5f)
                {
                    Item18.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item19 > 11.4f)
                {
                    Item19.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item20 > 10.6f)
                {
                    Item20.color = Color.red;
                }
            }

            if (expertMovementToLoad.Equals("Movement_10_transform"))
            {
                if (calculateJointAverage.CalculateAverage().Item1 > 72.5f)
                {
                    Item1.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item2 > 76.8f)
                {
                    Item2.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item3 > 65.8f)
                {
                    Item3.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item4 > 64.3f)
                {
                    Item4.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item5 > 66.0f)
                {
                    Item5.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item6 > 53.9f)
                {
                    Item6.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item7 > 48.1f)
                {
                    Item7.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item8 > 47.5f)
                {
                    Item8.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item9 > 78.8f)
                {
                    Item9.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item10 > 76.1f)
                {
                    Item10.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item11 > 74.4f)
                {
                    Item11.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item12 > 74.4f)
                {
                    Item12.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item13 > 66.7f)
                {
                    Item13.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item14 > 68.7f)
                {
                    Item14.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item15 > 76.4f)
                {
                    Item15.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item16 > 76.8f)
                {
                    Item16.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item17 > 74.5f)
                {
                    Item17.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item18 > 75.0f)
                {
                    Item18.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item19 > 71.9f)
                {
                    Item19.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item20 > 73.7f)
                {
                    Item20.color = Color.red;
                }
            }

            if (expertMovementToLoad.Equals("Movement_12_transform_v2"))
            {
                if (calculateJointAverage.CalculateAverage().Item1 > 166.6f)
                {
                    Item1.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item2 > 169.2f)
                {
                    Item2.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item3 > 177.7f)
                {
                    Item3.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item4 > 177.6f)
                {
                    Item4.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item5 > 170.7f)
                {
                    Item5.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item6 > 143.4f)
                {
                    Item6.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item7 > 119.2f)
                {
                    Item7.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item8 > 117.7f)
                {
                    Item8.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item9 > 166.9f)
                {
                    Item9.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item10 > 150.8f)
                {
                    Item10.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item11 > 144.1f)
                {
                    Item11.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item12 > 144.1f)
                {
                    Item12.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item13 > 165.1f)
                {
                    Item13.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item14 > 150.6f)
                {
                    Item14.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item15 > 157.9f)
                {
                    Item15.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item16 > 150.6f)
                {
                    Item16.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item17 > 164.1f)
                {
                    Item17.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item18 > 173.1f)
                {
                    Item18.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item19 > 183.5f)
                {
                    Item19.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item20 > 189.0f)
                {
                    Item20.color = Color.red;
                }
            }

            if (expertMovementToLoad.Equals("Movement_13_transform_v2"))
            {
                if (calculateJointAverage.CalculateAverage().Item1 > 72.4f)
                {
                    Item1.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item2 > 75.0f)
                {
                    Item2.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item3 > 79.7f)
                {
                    Item3.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item4 > 79.7f)
                {
                    Item4.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item5 > 79.2f)
                {
                    Item5.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item6 > 73.6f)
                {
                    Item6.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item7 > 65.5f)
                {
                    Item7.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item8 > 65.5f)
                {
                    Item8.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item9 > 69.3f)
                {
                    Item9.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item10 > 63.0f)
                {
                    Item10.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item11 > 49.8f)
                {
                    Item11.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item12 > 49.8f)
                {
                    Item12.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item13 > 73.9f)
                {
                    Item13.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item14 > 78.3f)
                {
                    Item14.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item15 > 87.1f)
                {
                    Item15.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item16 > 88.3f)
                {
                    Item16.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item17 > 68.6f)
                {
                    Item17.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item18 > 72.0f)
                {
                    Item18.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item19 > 75.8f)
                {
                    Item19.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item20 > 79.9f)
                {
                    Item20.color = Color.red;
                }
            }

            if (expertMovementToLoad.Equals("Movement_14_transform_v2"))
            {
                if (calculateJointAverage.CalculateAverage().Item1 > 67.3f)
                {
                    Item1.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item2 > 70.5f)
                {
                    Item2.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item3 > 75.6f)
                {
                    Item3.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item4 > 75.8f)
                {
                    Item4.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item5 > 76.4f)
                {
                    Item5.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item6 > 77.5f)
                {
                    Item6.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item7 > 67.9f)
                {
                    Item7.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item8 > 63.6f)
                {
                    Item8.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item9 > 66.6f)
                {
                    Item9.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item10 > 62.5f)
                {
                    Item10.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item11 > 46.6f)
                {
                    Item11.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item12 > 46.6f)
                {
                    Item12.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item13 > 67.5f)
                {
                    Item13.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item14 > 70.6f)
                {
                    Item14.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item15 > 84.6f)
                {
                    Item15.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item16 > 85.4f)
                {
                    Item16.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item17 > 63.1f)
                {
                    Item17.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item18 > 62.0f)
                {
                    Item18.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item19 > 70.2f)
                {
                    Item19.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item20 > 76.1f)
                {
                    Item20.color = Color.red;
                }
            }

            if (expertMovementToLoad.Equals("Movement_15_transform"))
            {
                if (calculateJointAverage.CalculateAverage().Item1 > 120.6f)
                {
                    Item1.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item2 > 120.6f)
                {
                    Item2.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item3 > 120.3f)
                {
                    Item3.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item4 > 120.3f)
                {
                    Item4.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item5 > 118.7f)
                {
                    Item5.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item6 > 120.2f)
                {
                    Item6.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item7 > 130.7f)
                {
                    Item7.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item8 > 141.0f)
                {
                    Item8.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item9 > 119.0f)
                {
                    Item9.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item10 > 117.8f)
                {
                    Item10.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item11 > 111.6f)
                {
                    Item11.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item12 > 111.6f)
                {
                    Item12.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item13 > 120.1f)
                {
                    Item13.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item14 > 125.6f)
                {
                    Item14.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item15 > 129.9f)
                {
                    Item15.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item16 > 129.1f)
                {
                    Item16.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item17 > 119.2f)
                {
                    Item17.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item18 > 124.7f)
                {
                    Item18.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item19 > 133.7f)
                {
                    Item19.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item20 > 133.8f)
                {
                    Item20.color = Color.red;
                }
            }

            if (expertMovementToLoad.Equals("Movement_16_transform"))
            {
                if (calculateJointAverage.CalculateAverage().Item1 > 41f)
                {
                    Item1.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item2 > 39.8f)
                {
                    Item2.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item3 > 40.2f)
                {
                    Item3.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item4 > 37.2f)
                {
                    Item4.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item5 > 40.2f)
                {
                    Item5.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item6 > 37.5f)
                {
                    Item6.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item7 > 34.2f)
                {
                    Item7.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item8 > 36.5f)
                {
                    Item8.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item9 > 35.3f)
                {
                    Item9.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item10 > 34.3f)
                {
                    Item10.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item11 > 33.4f)
                {
                    Item11.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item12 > 33.4f)
                {
                    Item12.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item13 > 42.7f)
                {
                    Item13.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item14 > 45.6f)
                {
                    Item14.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item15 > 56.1f)
                {
                    Item15.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item16 > 52.3f)
                {
                    Item16.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item17 > 39.2f)
                {
                    Item17.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item18 > 34.7f)
                {
                    Item18.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item19 > 33.8f)
                {
                    Item19.color = Color.red;
                }
                if (calculateJointAverage.CalculateAverage().Item20 > 29.5f)
                {
                    Item20.color = Color.red;
                }
            }

            Item1.text = calculateJointAverage.CalculateAverage().Item1.ToString("#.##");
            Item2.text = calculateJointAverage.CalculateAverage().Item2.ToString("#.##");
            Item3.text = calculateJointAverage.CalculateAverage().Item3.ToString("#.##");
            Item4.text = calculateJointAverage.CalculateAverage().Item4.ToString("#.##");
            Item5.text = calculateJointAverage.CalculateAverage().Item5.ToString("#.##");
            Item6.text = calculateJointAverage.CalculateAverage().Item6.ToString("#.##");
            Item7.text = calculateJointAverage.CalculateAverage().Item7.ToString("#.##");
            Item8.text = calculateJointAverage.CalculateAverage().Item8.ToString("#.##");
            Item9.text = calculateJointAverage.CalculateAverage().Item9.ToString("#.##");
            Item10.text = calculateJointAverage.CalculateAverage().Item10.ToString("#.##");
            Item11.text = calculateJointAverage.CalculateAverage().Item11.ToString("#.##");
            Item12.text = calculateJointAverage.CalculateAverage().Item12.ToString("#.##");
            Item13.text = calculateJointAverage.CalculateAverage().Item13.ToString("#.##");
            Item14.text = calculateJointAverage.CalculateAverage().Item14.ToString("#.##");
            Item15.text = calculateJointAverage.CalculateAverage().Item15.ToString("#.##");
            Item16.text = calculateJointAverage.CalculateAverage().Item16.ToString("#.##");
            Item17.text = calculateJointAverage.CalculateAverage().Item17.ToString("#.##");
            Item18.text = calculateJointAverage.CalculateAverage().Item18.ToString("#.##");
            Item19.text = calculateJointAverage.CalculateAverage().Item19.ToString("#.##");
            Item20.text = calculateJointAverage.CalculateAverage().Item20.ToString("#.##");

            foreach (GameObject textField in textFields)
            {
                textField.gameObject.SetActive(true);
            }

            //jointScores.text = text;
            compare = false;
        }
    }
}
