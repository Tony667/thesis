using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class NewLoadingSystem : MonoBehaviour
{
    public bool MoveVertically = false;
    public bool MirroredMovement = false;

    //public GameObject debugText;

    public GameObject Hip_Center;
    public GameObject Spine;
    public GameObject Shoulder_Center;
    public GameObject Head;
    public GameObject Shoulder_Left;
    public GameObject Elbow_Left;
    public GameObject Wrist_Left;
    public GameObject Hand_Left;
    public GameObject Shoulder_Right;
    public GameObject Elbow_Right;
    public GameObject Wrist_Right;
    public GameObject Hand_Right;
    public GameObject Hip_Left;
    public GameObject Knee_Left;
    public GameObject Ankle_Left;
    public GameObject Foot_Left;
    public GameObject Hip_Right;
    public GameObject Knee_Right;
    public GameObject Ankle_Right;
    public GameObject Foot_Right;

    private bool firstLine = true;

    // if it is loading data from a csv file or not
    public bool isLoading = false;

    // path to the csv file
    public string movementToLoad;
    public string context;
    public string[] sLine;

    // Update is called once per frame
    void Update()
    {
        if (isLoading)
        {
            if (File.Exists(Application.dataPath + "/MovementDataBase/" + movementToLoad + ".csv"))
            {
                using (StreamReader reader = File.OpenText(Application.dataPath + "/MovementDataBase/" + movementToLoad + ".csv"))
                {
                    while ((movementToLoad = reader.ReadLine()) != null)
                    {
                        if (firstLine)
                        {
                            firstLine = false;
                            continue;
                        }

                        context = movementToLoad;
                        sLine = context.Split(',');
                        Hip_Center.transform.Translate(float.Parse(sLine[2]), float.Parse(sLine[3]), float.Parse(sLine[4]));
                        Spine.transform.Translate(float.Parse(sLine[6]), float.Parse(sLine[7]), float.Parse(sLine[8]));
                        Shoulder_Center.transform.Translate(float.Parse(sLine[10]), float.Parse(sLine[11]), float.Parse(sLine[12]));
                        Head.transform.Translate(float.Parse(sLine[14]), float.Parse(sLine[15]), float.Parse(sLine[16]));
                        Shoulder_Left.transform.Translate(float.Parse(sLine[18]), float.Parse(sLine[19]), float.Parse(sLine[20]));
                        Elbow_Left.transform.Translate(float.Parse(sLine[22]), float.Parse(sLine[23]), float.Parse(sLine[24]));
                        Wrist_Left.transform.Translate(float.Parse(sLine[26]), float.Parse(sLine[27]), float.Parse(sLine[28]));
                        Hand_Left.transform.Translate(float.Parse(sLine[30]), float.Parse(sLine[31]), float.Parse(sLine[32]));
                        Shoulder_Right.transform.Translate(float.Parse(sLine[34]), float.Parse(sLine[35]), float.Parse(sLine[36]));
                        Elbow_Right.transform.Translate(float.Parse(sLine[38]), float.Parse(sLine[39]), float.Parse(sLine[40]));
                        Wrist_Right.transform.Translate(float.Parse(sLine[42]), float.Parse(sLine[43]), float.Parse(sLine[44]));
                        Hand_Right.transform.Translate(float.Parse(sLine[46]), float.Parse(sLine[47]), float.Parse(sLine[48]));
                        Hip_Left.transform.Translate(float.Parse(sLine[50]), float.Parse(sLine[51]), float.Parse(sLine[52]));
                        Knee_Left.transform.Translate(float.Parse(sLine[54]), float.Parse(sLine[55]), float.Parse(sLine[56]));
                        Ankle_Left.transform.Translate(float.Parse(sLine[58]), float.Parse(sLine[59]), float.Parse(sLine[60]));
                        Foot_Left.transform.Translate(float.Parse(sLine[62]), float.Parse(sLine[63]), float.Parse(sLine[64]));
                        Hip_Right.transform.Translate(float.Parse(sLine[66]), float.Parse(sLine[67]), float.Parse(sLine[68]));
                        Knee_Right.transform.Translate(float.Parse(sLine[70]), float.Parse(sLine[71]), float.Parse(sLine[72]));
                        Ankle_Right.transform.Translate(float.Parse(sLine[74]), float.Parse(sLine[75]), float.Parse(sLine[76]));
                        Foot_Right.transform.Translate(float.Parse(sLine[78]), float.Parse(sLine[79]), float.Parse(sLine[80]));
                    }
                }
            }
        }
    }
}