using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class LoadingWithCoroutine : MonoBehaviour
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

    private bool firstLine = true;

    //public AvatarControllerForLoading avatarControlerForLoading;
    //private List<AvatarControllerForLoading> PlayerControllers;
    //public List<GameObject> PlayerAvatars;

    // if it is loading data from a csv file or not
    public bool isLoading = false;

    // path to the csv file
    public string movementToLoad;

    //public string csvContent;

    public string[] fields;
    public string[] nextFields;
    public string[] contents;

    public int numberOfLines;
    int frameNumber = 2;
    int i;

    public float[,] animationFloats;
    int nframes = 100000;
    float timer = 0.1f;

    public int frameNo = 1;

    private JointProgression jointProgression;


    private void Start()
    {
        if (File.Exists(Application.dataPath + "/MovementDataBase/" + "ExpertMovement/" + movementToLoad + ".csv"))
        {
            contents = File.ReadAllLines(Application.dataPath + "/MovementDataBase/" + "ExpertMovement/" + movementToLoad + ".csv");
            numberOfLines = contents.Length;
        }
        jointProgression = new JointProgression();
    }


    IEnumerator SetJointTransform()
    {
        Debug.Log("Secs " + Time.time);
        if (frameNo < numberOfLines - 1)
        {
            fields = contents[frameNo].Split(';');
            nextFields = contents[frameNo + 1].Split(';');
        }
        else
        {
            frameNo = 1;
            fields = contents[frameNo].Split(';');
            nextFields = contents[frameNo + 1].Split(';');
        }

        Hip_Center.transform.position = new Vector3(float.Parse(fields[3]), float.Parse(fields[4]), float.Parse(fields[5]));
        Spine.transform.position = new Vector3(float.Parse(fields[7]), float.Parse(fields[8]), float.Parse(fields[9]));
        Shoulder_Center.transform.position = new Vector3(float.Parse(fields[11]), float.Parse(fields[12]), float.Parse(fields[13]));
        Head.transform.position = new Vector3(float.Parse(fields[15]), float.Parse(fields[16]), float.Parse(fields[17]));
        Shoulder_Left.transform.position = new Vector3(float.Parse(fields[19]), float.Parse(fields[20]), float.Parse(fields[21]));
        Elbow_Left.transform.position = new Vector3(float.Parse(fields[23]), float.Parse(fields[24]), float.Parse(fields[25]));
        Wrist_Left.transform.position = new Vector3(float.Parse(fields[27]), float.Parse(fields[28]), float.Parse(fields[29]));
        Hand_Left.transform.position = new Vector3(float.Parse(fields[31]), float.Parse(fields[32]), float.Parse(fields[33]));
        Shoulder_Right.transform.position = new Vector3(float.Parse(fields[35]), float.Parse(fields[36]), float.Parse(fields[37]));
        Elbow_Right.transform.position = new Vector3(float.Parse(fields[39]), float.Parse(fields[40]), float.Parse(fields[41]));
        Wrist_Right.transform.position = new Vector3(float.Parse(fields[43]), float.Parse(fields[44]), float.Parse(fields[45]));
        Hand_Right.transform.position = new Vector3(float.Parse(fields[47]), float.Parse(fields[48]), float.Parse(fields[49]));
        Hip_Left.transform.position = new Vector3(float.Parse(fields[51]), float.Parse(fields[52]), float.Parse(fields[53]));
        Knee_Left.transform.position = new Vector3(float.Parse(fields[55]), float.Parse(fields[56]), float.Parse(fields[57]));
        Ankle_Left.transform.position = new Vector3(float.Parse(fields[59]), float.Parse(fields[60]), float.Parse(fields[61]));
        Foot_Left.transform.position = new Vector3(float.Parse(fields[63]), float.Parse(fields[64]), float.Parse(fields[65]));
        Hip_Right.transform.position = new Vector3(float.Parse(fields[67]), float.Parse(fields[68]), float.Parse(fields[69]));
        Knee_Right.transform.position = new Vector3(float.Parse(fields[71]), float.Parse(fields[72]), float.Parse(fields[73]));
        Ankle_Right.transform.position = new Vector3(float.Parse(fields[75]), float.Parse(fields[76]), float.Parse(fields[77]));
        Foot_Right.transform.position = new Vector3(float.Parse(fields[79]), float.Parse(fields[80]), float.Parse(fields[81]));

        float currentTime = float.Parse(fields[1]);
        float followingTime = float.Parse(fields[1]);

        yield return new WaitForSeconds(followingTime - currentTime);
    }

    public void Update()
    {

        StartCoroutine(SetJointTransform());

        frameNo++;
    }
}
