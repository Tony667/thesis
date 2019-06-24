﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Globalization;

public class LoadingSystem : MonoBehaviour
{
    // the joint we want to track
    //private KinectWrapper.NuiSkeletonPositionIndex HipCenter = KinectWrapper.NuiSkeletonPositionIndex.HipCenter;
    //private KinectWrapper.NuiSkeletonPositionIndex Spine = KinectWrapper.NuiSkeletonPositionIndex.Spine;
    //private KinectWrapper.NuiSkeletonPositionIndex ShoulderCenter = KinectWrapper.NuiSkeletonPositionIndex.ShoulderCenter;
    //private KinectWrapper.NuiSkeletonPositionIndex Head = KinectWrapper.NuiSkeletonPositionIndex.Head;
    //private KinectWrapper.NuiSkeletonPositionIndex ShoulderLeft = KinectWrapper.NuiSkeletonPositionIndex.ShoulderLeft;
    //private KinectWrapper.NuiSkeletonPositionIndex ElbowLeft = KinectWrapper.NuiSkeletonPositionIndex.ElbowLeft;
    //private KinectWrapper.NuiSkeletonPositionIndex WristLeft = KinectWrapper.NuiSkeletonPositionIndex.WristLeft;
    //private KinectWrapper.NuiSkeletonPositionIndex HandLeft = KinectWrapper.NuiSkeletonPositionIndex.HandLeft;
    //private KinectWrapper.NuiSkeletonPositionIndex ShoulderRight = KinectWrapper.NuiSkeletonPositionIndex.ShoulderRight;
    //private KinectWrapper.NuiSkeletonPositionIndex ElbowRight = KinectWrapper.NuiSkeletonPositionIndex.ElbowRight;
    //private KinectWrapper.NuiSkeletonPositionIndex WristRight = KinectWrapper.NuiSkeletonPositionIndex.WristRight;
    //private KinectWrapper.NuiSkeletonPositionIndex HandRight = KinectWrapper.NuiSkeletonPositionIndex.WristRight;
    //private KinectWrapper.NuiSkeletonPositionIndex HipLeft = KinectWrapper.NuiSkeletonPositionIndex.HipLeft;
    //private KinectWrapper.NuiSkeletonPositionIndex KneeLeft = KinectWrapper.NuiSkeletonPositionIndex.KneeLeft;
    //private KinectWrapper.NuiSkeletonPositionIndex AnkleLeft = KinectWrapper.NuiSkeletonPositionIndex.AnkleLeft;
    //private KinectWrapper.NuiSkeletonPositionIndex FootLeft = KinectWrapper.NuiSkeletonPositionIndex.FootLeft;
    //private KinectWrapper.NuiSkeletonPositionIndex HipRight = KinectWrapper.NuiSkeletonPositionIndex.HipRight;
    //private KinectWrapper.NuiSkeletonPositionIndex KneeRight = KinectWrapper.NuiSkeletonPositionIndex.KneeRight;
    //private KinectWrapper.NuiSkeletonPositionIndex AnkleRight = KinectWrapper.NuiSkeletonPositionIndex.AnkleRight;
    //private KinectWrapper.NuiSkeletonPositionIndex FootRight = KinectWrapper.NuiSkeletonPositionIndex.FootRight;

    //// joint coordinates in 3D space
    //private Vector3 HipCenterCoordinates;
    //private Vector3 SpineCoordinates;
    //private Vector3 ShoulderCenterCoordinates;
    //private Vector3 HeadCoordinates;
    //private Vector3 ShoulderLeftCoordinates;
    //private Vector3 ElbowLeftCoordinates;
    //private Vector3 WristLeftCoordinates;
    //private Vector3 HandLeftCoordinates;
    //private Vector3 ShoulderRightCoordinates;
    //private Vector3 ElbowRightCoordinates;
    //private Vector3 WristRightCoordinates;
    //private Vector3 HandRightCoordinates;
    //private Vector3 HipLeftCoordinates;
    //private Vector3 KneeLeftCoordinates;
    //private Vector3 AnkleLeftCoordinates;
    //private Vector3 FootLeftCoordinates;
    //private Vector3 HipRightCoordinates;
    //private Vector3 KneeRightCoordinates;
    //private Vector3 AnkleRightCoordinates;
    //private Vector3 FootRightCoordinates;

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

    public string csvContent;

    //public string[] contents;
    public string[] fields;

    int frameNumber = 1;


    //// recreates and reinitializes the lists of avatar controllers, after the list of avatars for player 1/2 was changed
    //public void ResetAvatarControllers()
    //{
    //    if (PlayerAvatars.Count == 0)
    //    {
    //        AvatarControllerForLoading[] avatars = FindObjectsOfType(typeof(AvatarControllerForLoading)) as AvatarControllerForLoading[];

    //        foreach (AvatarControllerForLoading avatar in avatars)
    //        {
    //            PlayerAvatars.Add(avatar.gameObject);
    //        }
    //    }

    //    if (PlayerControllers != null)
    //    {
    //        PlayerControllers.Clear();

    //        foreach (GameObject avatar in PlayerAvatars)
    //        {
    //            if (avatar != null && avatar.activeInHierarchy)
    //            {
    //                AvatarControllerForLoading avatarControlerForLoading = avatar.GetComponent<AvatarControllerForLoading>();
    //                avatarControlerForLoading.ResetToInitialPosition();
    //                avatarControlerForLoading.Awake();

    //                PlayerControllers.Add(avatarControlerForLoading);
    //            }
    //        }
    //    }
    //}


    //void Start()
    //{
    //    //avatarControlerForLoading = FindObjectOfType<AvatarControllerForLoading>();

    //    // try to automatically find the available avatar controllers in the scene
    //    if (PlayerAvatars.Count == 0)
    //    {
    //        AvatarControllerForLoading[] avatars = FindObjectsOfType(typeof(AvatarControllerForLoading)) as AvatarControllerForLoading[];

    //        foreach (AvatarControllerForLoading avatar in avatars)
    //        {
    //            PlayerAvatars.Add(avatar.gameObject);
    //        }
    //    }

    //    PlayerControllers = new List<AvatarControllerForLoading>();

    //    // Add each of the avatars' controllers into a list for each player.
    //    foreach (GameObject avatar in PlayerAvatars)
    //    {
    //        if (avatar != null && avatar.activeInHierarchy)
    //        {
    //            PlayerControllers.Add(avatar.GetComponent<AvatarControllerForLoading>());
    //        }
    //    }
    //}

    public void Update()
    {
        if (isLoading)
        {
            if (File.Exists(Application.dataPath + "/MovementDataBase/" + movementToLoad + ".csv"))
            {
                //contents = File.ReadAllLines(Application.dataPath + "/MovementDataBase/" + movementToLoad + ".csv");
                //foreach(string line in contents)
                //{
                //    if(line.StartsWith("Frame" + frameNumber.ToString()))
                //    {
                //        fields = line.Split(';');
                //        foreach(string field in fields)
                //        {
                //            Hip_Center.transform.position = new Vector3(float.Parse(fields[3]), float.Parse(fields[4]), float.Parse(fields[5]));
                //            Spine.transform.position = new Vector3(float.Parse(fields[7]), float.Parse(fields[8]), float.Parse(fields[9]));
                //            Shoulder_Center.transform.position = new Vector3(float.Parse(fields[11]), float.Parse(fields[12]), float.Parse(fields[13]));
                //            Head.transform.position = new Vector3(float.Parse(fields[15]), float.Parse(fields[16]), float.Parse(fields[17]));
                //            Shoulder_Left.transform.position = new Vector3(float.Parse(fields[19]), float.Parse(fields[20]), float.Parse(fields[21]));
                //            Elbow_Left.transform.position = new Vector3(float.Parse(fields[23]), float.Parse(fields[24]), float.Parse(fields[25]));
                //            Wrist_Left.transform.position = new Vector3(float.Parse(fields[27]), float.Parse(fields[28]), float.Parse(fields[29]));
                //            Hand_Left.transform.position = new Vector3(float.Parse(fields[31]), float.Parse(fields[32]), float.Parse(fields[33]));
                //            Shoulder_Right.transform.position = new Vector3(float.Parse(fields[35]), float.Parse(fields[36]), float.Parse(fields[37]));
                //            Elbow_Right.transform.position = new Vector3(float.Parse(fields[39]), float.Parse(fields[40]), float.Parse(fields[41]));
                //            Wrist_Right.transform.position = new Vector3(float.Parse(fields[43]), float.Parse(fields[44]), float.Parse(fields[45]));
                //            Hand_Right.transform.position = new Vector3(float.Parse(fields[47]), float.Parse(fields[48]), float.Parse(fields[49]));
                //            Hip_Left.transform.position = new Vector3(float.Parse(fields[51]), float.Parse(fields[52]), float.Parse(fields[53]));
                //            Knee_Left.transform.position = new Vector3(float.Parse(fields[55]), float.Parse(fields[56]), float.Parse(fields[57]));
                //            Ankle_Left.transform.position = new Vector3(float.Parse(fields[59]), float.Parse(fields[60]), float.Parse(fields[61]));
                //            Foot_Left.transform.position = new Vector3(float.Parse(fields[63]), float.Parse(fields[64]), float.Parse(fields[65]));
                //            Hip_Right.transform.position = new Vector3(float.Parse(fields[67]), float.Parse(fields[68]), float.Parse(fields[69]));
                //            Knee_Right.transform.position = new Vector3(float.Parse(fields[71]), float.Parse(fields[72]), float.Parse(fields[73]));
                //            Ankle_Right.transform.position = new Vector3(float.Parse(fields[75]), float.Parse(fields[76]), float.Parse(fields[77]));
                //            Foot_Right.transform.position = new Vector3(float.Parse(fields[79]), float.Parse(fields[80]), float.Parse(fields[81]));
                //        }
                //        frameNumber++;
                //        Debug.Log(frameNumber);
                //    }
                //}

                using(StreamReader reader = File.OpenText(Application.dataPath + "/MovementDataBase/" + movementToLoad + ".csv"))
                {
                    while((csvContent = reader.ReadLine()) != null)
                    {
                        if(csvContent.StartsWith("Frame" + frameNumber))
                        {
                            fields = csvContent.Split(new string[] { ";" }, System.StringSplitOptions.None);
                            foreach(string field in fields)
                            {
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
                            }
                            frameNumber++;
                        }
                    }
                }
            //    using (StreamReader reader = File.OpenText(Application.dataPath + "/MovementDataBase/" + movementToLoad + ".csv"))
            //    {
            //        while ((movementToLoad = reader.ReadLine()) != null)
            //        {
            //            if (firstLine)
            //            {
            //                firstLine = false;
            //                continue;
            //            }
            //            fields = movementToLoad.Split(',');

            //            if (fields.Sta)
            //            {
            //                Hip_Center.transform.position = new Vector3(float.Parse(fields[3]), float.Parse(fields[4]), float.Parse(fields[5]));
            //                Spine.transform.position = new Vector3(float.Parse(fields[7]), float.Parse(fields[8]), float.Parse(fields[9]));
            //                Shoulder_Center.transform.position = new Vector3(float.Parse(fields[11]), float.Parse(fields[12]), float.Parse(fields[13]));
            //                Head.transform.position = new Vector3(float.Parse(fields[15]), float.Parse(fields[16]), float.Parse(fields[17]));
            //                Shoulder_Left.transform.position = new Vector3(float.Parse(fields[19]), float.Parse(fields[20]), float.Parse(fields[21]));
            //                Elbow_Left.transform.position = new Vector3(float.Parse(fields[23]), float.Parse(fields[24]), float.Parse(fields[25]));
            //                Wrist_Left.transform.position = new Vector3(float.Parse(fields[27]), float.Parse(fields[28]), float.Parse(fields[29]));
            //                Hand_Left.transform.position = new Vector3(float.Parse(fields[31]), float.Parse(fields[32]), float.Parse(fields[33]));
            //                Shoulder_Right.transform.position = new Vector3(float.Parse(fields[35]), float.Parse(fields[36]), float.Parse(fields[37]));
            //                Elbow_Right.transform.position = new Vector3(float.Parse(fields[39]), float.Parse(fields[40]), float.Parse(fields[41]));
            //                Wrist_Right.transform.position = new Vector3(float.Parse(fields[43]), float.Parse(fields[44]), float.Parse(fields[45]));
            //                Hand_Right.transform.position = new Vector3(float.Parse(fields[47]), float.Parse(fields[48]), float.Parse(fields[49]));
            //                Hip_Left.transform.position = new Vector3(float.Parse(fields[51]), float.Parse(fields[52]), float.Parse(fields[53]));
            //                Knee_Left.transform.position = new Vector3(float.Parse(fields[55]), float.Parse(fields[56]), float.Parse(fields[57]));
            //                Ankle_Left.transform.position = new Vector3(float.Parse(fields[59]), float.Parse(fields[60]), float.Parse(fields[61]));
            //                Foot_Left.transform.position = new Vector3(float.Parse(fields[63]), float.Parse(fields[64]), float.Parse(fields[65]));
            //                Hip_Right.transform.position = new Vector3(float.Parse(fields[67]), float.Parse(fields[68]), float.Parse(fields[69]));
            //                Knee_Right.transform.position = new Vector3(float.Parse(fields[71]), float.Parse(fields[72]), float.Parse(fields[73]));
            //                Ankle_Right.transform.position = new Vector3(float.Parse(fields[75]), float.Parse(fields[76]), float.Parse(fields[77]));
            //                Foot_Right.transform.position = new Vector3(float.Parse(fields[79]), float.Parse(fields[80]), float.Parse(fields[81]));
            //            }
                        

            //            ////(int)HipCenter = int.Parse(sLine[1]);
            //            //HipCenterCoordinates.x = float.Parse(sLine[2]);
            //            //HipCenterCoordinates.y = float.Parse(sLine[3]);
            //            //HipCenterCoordinates.z = float.Parse(sLine[4]);
            //            ////Spine = float.Parse(sLine[5]);
            //            //SpineCoordinates.x = float.Parse(sLine[6]);
            //            //SpineCoordinates.y = float.Parse(sLine[7]);
            //            //SpineCoordinates.z = float.Parse(sLine[8]);
            //            ////ShoulderCenter = float.Parse(sLine[9]);
            //            //ShoulderCenterCoordinates.x = float.Parse(sLine[10]);
            //            //ShoulderCenterCoordinates.y = float.Parse(sLine[11]);
            //            //ShoulderCenterCoordinates.z = float.Parse(sLine[12]);
            //            ////Head = float.Parse(sLine[13]);
            //            //HeadCoordinates.x = float.Parse(sLine[14]);
            //            //HeadCoordinates.y = float.Parse(sLine[15]);
            //            //HeadCoordinates.z = float.Parse(sLine[16]);
            //            ////ShoulderLeft = float.Parse(sLine[17]);
            //            //ShoulderLeftCoordinates.x = float.Parse(sLine[18]);
            //            //ShoulderLeftCoordinates.y = float.Parse(sLine[19]);
            //            //ShoulderLeftCoordinates.z = float.Parse(sLine[20]);
            //            ////ElbowLeft = float.Parse(sLine[21]);
            //            //ElbowLeftCoordinates.x = float.Parse(sLine[22]);
            //            //ElbowLeftCoordinates.y = float.Parse(sLine[23]);
            //            //ElbowLeftCoordinates.z = float.Parse(sLine[24]);
            //            ////WristLeft = float.Parse(sLine[25]);
            //            //WristLeftCoordinates.x = float.Parse(sLine[26]);
            //            //WristLeftCoordinates.y = float.Parse(sLine[27]);
            //            //WristLeftCoordinates.z = float.Parse(sLine[28]);
            //            ////HandLeft = float.Parse(sLine[29]);
            //            //HandLeftCoordinates.x = float.Parse(sLine[30]);
            //            //HandLeftCoordinates.y = float.Parse(sLine[31]);
            //            //HandLeftCoordinates.z = float.Parse(sLine[32]);
            //            ////ShoulderRight = float.Parse(sLine[33]);
            //            //ShoulderRightCoordinates.x = float.Parse(sLine[34]);
            //            //ShoulderRightCoordinates.y = float.Parse(sLine[35]);
            //            //ShoulderRightCoordinates.z = float.Parse(sLine[36]);
            //            ////ElbowRight = float.Parse(sLine[37]);
            //            //ElbowRightCoordinates.x = float.Parse(sLine[38]);
            //            //ElbowRightCoordinates.y = float.Parse(sLine[39]);
            //            //ElbowRightCoordinates.z = float.Parse(sLine[40]);
            //            ////WristRight = float.Parse(sLine[41]);
            //            //WristRightCoordinates.x = float.Parse(sLine[42]);
            //            //WristRightCoordinates.y = float.Parse(sLine[43]);
            //            //WristRightCoordinates.z = float.Parse(sLine[44]);
            //            ////HandRight = float.Parse(sLine[45]);
            //            //HandRightCoordinates.x = float.Parse(sLine[46]);
            //            //HandRightCoordinates.y = float.Parse(sLine[47]);
            //            //HandRightCoordinates.z = float.Parse(sLine[48]);
            //            ////HipLeft = float.Parse(sLine[49]);
            //            //HipLeftCoordinates.x = float.Parse(sLine[50]);
            //            //HipLeftCoordinates.y = float.Parse(sLine[51]);
            //            //HipLeftCoordinates.z = float.Parse(sLine[52]);
            //            ////KneeLeft = float.Parse(sLine[53]);
            //            //KneeLeftCoordinates.x = float.Parse(sLine[54]);
            //            //KneeLeftCoordinates.y = float.Parse(sLine[55]);
            //            //KneeLeftCoordinates.z = float.Parse(sLine[56]);
            //            ////AnkleLeft = float.Parse(sLine[57]);
            //            //AnkleLeftCoordinates.x = float.Parse(sLine[58]);
            //            //AnkleLeftCoordinates.y = float.Parse(sLine[59]);
            //            //AnkleLeftCoordinates.z = float.Parse(sLine[60]);
            //            ////FootLeft = float.Parse(sLine[61]);
            //            //FootLeftCoordinates.x = float.Parse(sLine[62]);
            //            //FootLeftCoordinates.y = float.Parse(sLine[63]);
            //            //FootLeftCoordinates.z = float.Parse(sLine[64]);
            //            ////HipRight = float.Parse(sLine[65]);
            //            //HipRightCoordinates.x = float.Parse(sLine[66]);
            //            //HipRightCoordinates.y = float.Parse(sLine[67]);
            //            //HipRightCoordinates.z = float.Parse(sLine[68]);
            //            ////KneeRight = float.Parse(sLine[69]);
            //            //KneeRightCoordinates.x = float.Parse(sLine[70]);
            //            //KneeRightCoordinates.y = float.Parse(sLine[71]);
            //            //KneeRightCoordinates.z = float.Parse(sLine[72]);
            //            ////AnkleRight = float.Parse(sLine[73]);
            //            //AnkleRightCoordinates.x = float.Parse(sLine[74]);
            //            //AnkleRightCoordinates.y = float.Parse(sLine[75]);
            //            //AnkleRightCoordinates.z = float.Parse(sLine[76]);
            //            ////FootRight = float.Parse(sLine[77]);
            //            //FootRightCoordinates.x = float.Parse(sLine[78]);
            //            //FootRightCoordinates.y = float.Parse(sLine[79]);
            //            //FootRightCoordinates.z = float.Parse(sLine[80]);
            //            Debug.Log(Wrist_Right.transform.position);

            //            //foreach (AvatarControllerForLoading avatarControllerForLoading in PlayerControllers)
            //            //{
            //            //    Debug.Log("in foreach");
            //            //    avatarControllerForLoading.UpdateAvatar();
            //            //}
            //        }
            //    }
            }
        }
    }
}
