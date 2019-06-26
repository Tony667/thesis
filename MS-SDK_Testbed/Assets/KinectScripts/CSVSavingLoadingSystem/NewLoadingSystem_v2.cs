using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewLoadingSystem_v2 : MonoBehaviour
{
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

    public TextAsset csvFile;

    public string[] lines;
    public string[] fields;

    void Update()
    {
        ReadCSV();        
    }

    void ReadCSV()
    {
        lines = csvFile.text.Split('\n');
        for(int i = 1; i < lines.Length; i++)
        {
            Debug.Log(i);
            fields = lines[i].Split(',');
            Hip_Center.transform.Translate(float.Parse(fields[2]), float.Parse(fields[3]), float.Parse(fields[4]));
            Spine.transform.Translate(float.Parse(fields[6]), float.Parse(fields[7]), float.Parse(fields[8]));
            Shoulder_Center.transform.Translate(float.Parse(fields[10]), float.Parse(fields[11]), float.Parse(fields[12]));
            Head.transform.Translate(float.Parse(fields[14]), float.Parse(fields[15]), float.Parse(fields[16]));
            Shoulder_Left.transform.Translate(float.Parse(fields[18]), float.Parse(fields[19]), float.Parse(fields[20]));
            Elbow_Left.transform.Translate(float.Parse(fields[22]), float.Parse(fields[23]), float.Parse(fields[24]));
            Wrist_Left.transform.Translate(float.Parse(fields[26]), float.Parse(fields[27]), float.Parse(fields[28]));
            Hand_Left.transform.Translate(float.Parse(fields[30]), float.Parse(fields[31]), float.Parse(fields[32]));
            Shoulder_Right.transform.Translate(float.Parse(fields[34]), float.Parse(fields[35]), float.Parse(fields[36]));
            Elbow_Right.transform.Translate(float.Parse(fields[38]), float.Parse(fields[39]), float.Parse(fields[40]));
            Wrist_Right.transform.Translate(float.Parse(fields[42]), float.Parse(fields[43]), float.Parse(fields[44]));
            Hand_Right.transform.Translate(float.Parse(fields[46]), float.Parse(fields[47]), float.Parse(fields[48]));
            Hip_Left.transform.Translate(float.Parse(fields[50]), float.Parse(fields[51]), float.Parse(fields[52]));
            Knee_Left.transform.Translate(float.Parse(fields[54]), float.Parse(fields[55]), float.Parse(fields[56]));
            Ankle_Left.transform.Translate(float.Parse(fields[58]), float.Parse(fields[59]), float.Parse(fields[60]));
            Foot_Left.transform.Translate(float.Parse(fields[62]), float.Parse(fields[63]), float.Parse(fields[64]));
            Hip_Right.transform.Translate(float.Parse(fields[66]), float.Parse(fields[67]), float.Parse(fields[68]));
            Knee_Right.transform.Translate(float.Parse(fields[70]), float.Parse(fields[71]), float.Parse(fields[72]));
            Ankle_Right.transform.Translate(float.Parse(fields[74]), float.Parse(fields[75]), float.Parse(fields[76]));
            Foot_Right.transform.Translate(float.Parse(fields[78]), float.Parse(fields[79]), float.Parse(fields[80]));
        }
    }
}
