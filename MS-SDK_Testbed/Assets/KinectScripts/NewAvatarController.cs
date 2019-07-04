using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class NewAvatarController : MonoBehaviour
{
    // Public variables that will get matched to bones. If empty, the Kinect will simply not track it.
    public Transform HipCenter;
    public Transform Spine;
    public Transform Neck;
    public Transform Head;

    public Transform LeftClavicle;
    public Transform LeftUpperArm;
    public Transform LeftElbow;
    public Transform LeftHand;
    private Transform LeftFingers = null;

    public Transform RightClavicle;
    public Transform RightUpperArm;
    public Transform RightElbow;
    public Transform RightHand;
    private Transform RightFingers = null;

    public Transform LeftThigh;
    public Transform LeftKnee;
    public Transform LeftFoot;
    private Transform LeftToes = null;

    public Transform RightThigh;
    public Transform RightKnee;
    public Transform RightFoot;
    private Transform RightToes = null;

    public Transform BodyRoot;
    public GameObject OffsetNode;

    public Transform[] bones;
    public Transform bodyRoot;
    public GameObject offsetNode;

    public string movementToLoad;
    public string[] contents;
    public int numberOfLines;
    public string[] fields;
    public int frameNumber = 1;

    // If the bones to be mapped have been declared, map that bone to the model.
    protected void MapBones()
    {
        bones[0] = HipCenter;
        bones[1] = Spine;
        bones[2] = Neck;
        bones[3] = Head;

        bones[4] = LeftClavicle;
        bones[5] = LeftUpperArm;
        bones[6] = LeftElbow;
        bones[7] = LeftHand;
        bones[8] = LeftFingers;

        bones[9] = RightClavicle;
        bones[10] = RightUpperArm;
        bones[11] = RightElbow;
        bones[12] = RightHand;
        bones[13] = RightFingers;

        bones[14] = LeftThigh;
        bones[15] = LeftKnee;
        bones[16] = LeftFoot;
        bones[17] = LeftToes;

        bones[18] = RightThigh;
        bones[19] = RightKnee;
        bones[20] = RightFoot;
        bones[21] = RightToes;

        // body root and offset
        bodyRoot = BodyRoot;
        //bodyRoot = transform;
        offsetNode = OffsetNode;

        if (offsetNode == null)
        {
            offsetNode = new GameObject(name + "Ctrl") { layer = transform.gameObject.layer, tag = transform.gameObject.tag };
            offsetNode.transform.position = transform.position;
            offsetNode.transform.rotation = transform.rotation;
            offsetNode.transform.parent = transform.parent;

            transform.parent = offsetNode.transform;
            transform.localPosition = Vector3.zero;
            transform.localRotation = Quaternion.identity;
        }

        //		if(bodyRoot == null)
        //		{
        //			bodyRoot = transform;
        //		}
    }

    private void Start()
    {
        bones = new Transform[22];

        MapBones();

        if (File.Exists(Application.dataPath + "/MovementDataBase/" + movementToLoad + ".csv"))
        {
            contents = File.ReadAllLines(Application.dataPath + "/MovementDataBase/" + movementToLoad + ".csv");
            numberOfLines = contents.Length;
        }
    }

    private void Update()
    {
        fields = contents[frameNumber].Split(';');
        HipCenter.transform.position = new Vector3(float.Parse(fields[3]), float.Parse(fields[4]), float.Parse(fields[5]));
        Spine.transform.position = new Vector3(float.Parse(fields[7]), float.Parse(fields[8]), float.Parse(fields[9]));
        Neck.transform.position = new Vector3(float.Parse(fields[11]), float.Parse(fields[12]), float.Parse(fields[13]));
        Head.transform.position = new Vector3(float.Parse(fields[15]), float.Parse(fields[16]), float.Parse(fields[17]));
        LeftClavicle.transform.position = new Vector3(float.Parse(fields[19]), float.Parse(fields[20]), float.Parse(fields[21]));
        LeftUpperArm.transform.position = new Vector3(float.Parse(fields[23]), float.Parse(fields[24]), float.Parse(fields[25]));
        LeftElbow.transform.position = new Vector3(float.Parse(fields[27]), float.Parse(fields[28]), float.Parse(fields[29]));
        LeftHand.transform.position = new Vector3(float.Parse(fields[31]), float.Parse(fields[32]), float.Parse(fields[33]));
        RightClavicle.transform.position = new Vector3(float.Parse(fields[35]), float.Parse(fields[36]), float.Parse(fields[37]));
        RightUpperArm.transform.position = new Vector3(float.Parse(fields[39]), float.Parse(fields[40]), float.Parse(fields[41]));
        RightElbow.transform.position = new Vector3(float.Parse(fields[43]), float.Parse(fields[44]), float.Parse(fields[45]));
        RightHand.transform.position = new Vector3(float.Parse(fields[47]), float.Parse(fields[48]), float.Parse(fields[49]));
        LeftThigh.transform.position = new Vector3(float.Parse(fields[51]), float.Parse(fields[52]), float.Parse(fields[53]));
        LeftKnee.transform.position = new Vector3(float.Parse(fields[55]), float.Parse(fields[56]), float.Parse(fields[57]));
        LeftFoot.transform.position = new Vector3(float.Parse(fields[59]), float.Parse(fields[60]), float.Parse(fields[61]));
        //FootLeft.transform.position = new Vector3(float.Parse(fields[63]), float.Parse(fields[64]), float.Parse(fields[65]));
        RightThigh.transform.position = new Vector3(float.Parse(fields[67]), float.Parse(fields[68]), float.Parse(fields[69]));
        RightKnee.transform.position = new Vector3(float.Parse(fields[71]), float.Parse(fields[72]), float.Parse(fields[73]));
        RightFoot.transform.position = new Vector3(float.Parse(fields[75]), float.Parse(fields[76]), float.Parse(fields[77]));
        //FootRight.transform.position = new Vector3(float.Parse(fields[79]), float.Parse(fields[80]), float.Parse(fields[81]));

        frameNumber++;

        if (frameNumber >= numberOfLines)
        {
            frameNumber = 1;
        }
    }
}
