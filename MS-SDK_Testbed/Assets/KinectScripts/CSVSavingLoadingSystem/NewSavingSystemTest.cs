using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class NewSavingSystemTest : MonoBehaviour
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

    // joint coordinates in 3D space
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

    List<long> timestamp = new List<long>();
    List<Vector3> _Hip_Center = new List<Vector3>();
    List<Vector3> _Spine = new List<Vector3>();
    List<Vector3> _Shoulder_Center = new List<Vector3>();
    List<Vector3> _Head = new List<Vector3>();
    List<Vector3> _Shoulder_Left = new List<Vector3>();
    List<Vector3> _Elbow_Left = new List<Vector3>();
    List<Vector3> _Wrist_Left = new List<Vector3>();
    List<Vector3> _Hand_Left = new List<Vector3>();
    List<Vector3> _Shoulder_Right = new List<Vector3>();
    List<Vector3> _Elbow_Right = new List<Vector3>();
    List<Vector3> _Wrist_Right = new List<Vector3>();
    List<Vector3> _Hand_Right = new List<Vector3>();
    List<Vector3> _Hip_Left = new List<Vector3>();
    List<Vector3> _Knee_Left = new List<Vector3>();
    List<Vector3> _Ankle_Left = new List<Vector3>();
    List<Vector3> _Foot_Left = new List<Vector3>();
    List<Vector3> _Hip_Right = new List<Vector3>();
    List<Vector3> _Knee_Right = new List<Vector3>();
    List<Vector3> _Ankle_Right = new List<Vector3>();
    List<Vector3> _Foot_Right = new List<Vector3>();

    Dictionary<string, List<Vector3>> store = new Dictionary<string, List<Vector3>>();

    // if it is saving data to a csv file or not
    public bool isSaving = false;

    // how many seconds to save data into the csv file, or 0 to save non-stop
    public float secondsToSave = 0f;

    // path to the csv file (;-limited)
    public string movementName;

    // start time of data saving to csv file
    private float saveStartTime = -1f;

    // get the joint position
    KinectManager manager;

    string sLine;
    string hLine;
    string frame = "Frame";
    int frameNumber = 1;

    private void Awake()
    {
        MovementDataBasePathCheck.Init();

        // get the joint position
        manager = KinectManager.Instance;
    }

    // Update is called once per frame
    void Update()
    {
        if (manager && manager.IsInitialized())
        {
            if (manager.IsUserDetected())
            {
                //uint userId = manager.GetPlayer1ID();

                //// output the joint position for easy tracking
                //HipCenterCoordinates = transform.eulerAngles;
                //SpineCoordinates = transform.eulerAngles;
                //ShoulderCenterCoordinates = transform.eulerAngles;
                //HeadCoordinates = transform.eulerAngles;
                //ShoulderLeftCoordinates = transform.eulerAngles;
                //ElbowLeftCoordinates = transform.eulerAngles;
                //WristLeftCoordinates = transform.eulerAngles;
                //HandLeftCoordinates = transform.eulerAngles;
                //ShoulderRightCoordinates = transform.eulerAngles;
                //ElbowRightCoordinates = transform.eulerAngles;
                //WristRightCoordinates = transform.eulerAngles;
                //HandRightCoordinates = transform.eulerAngles;
                //HipLeftCoordinates = transform.eulerAngles;
                //KneeLeftCoordinates = transform.eulerAngles;
                //AnkleLeftCoordinates = transform.eulerAngles;
                //FootLeftCoordinates = transform.eulerAngles;
                //HipRightCoordinates = transform.eulerAngles;
                //KneeRightCoordinates = transform.eulerAngles;
                //AnkleRightCoordinates = transform.eulerAngles;
                //FootRightCoordinates = transform.eulerAngles;

                //Vector3 jointPos = manager.GetJointPosition(userId, (int)joint);
                //outputPosition = jointPos;
                if (isSaving)
                {
                    long timestampNow = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
                    timestamp.Add(timestampNow);

                    _Hip_Center.Add(Hip_Center.transform.eulerAngles);
                    _Spine.Add(Spine.transform.eulerAngles);
                    _Shoulder_Center.Add(Shoulder_Center.transform.eulerAngles);
                    _Head.Add(Head.transform.eulerAngles);
                    _Shoulder_Left.Add(Shoulder_Left.transform.eulerAngles);
                    _Elbow_Left.Add(Elbow_Left.transform.eulerAngles);
                    _Wrist_Left.Add(Wrist_Left.transform.eulerAngles);
                    _Hand_Left.Add(Hand_Left.transform.eulerAngles);
                    _Shoulder_Right.Add(Shoulder_Right.transform.eulerAngles);
                    _Elbow_Right.Add(Elbow_Right.transform.eulerAngles);
                    _Wrist_Right.Add(Wrist_Right.transform.eulerAngles);
                    _Hand_Right.Add(Hand_Right.transform.eulerAngles);
                    _Hip_Left.Add(Hip_Left.transform.eulerAngles);
                    _Knee_Left.Add(Knee_Left.transform.eulerAngles);
                    _Ankle_Left.Add(Ankle_Left.transform.eulerAngles);
                    _Foot_Left.Add(Foot_Left.transform.eulerAngles);
                    _Hip_Right.Add(Hip_Right.transform.eulerAngles);
                    _Knee_Right.Add(Knee_Right.transform.eulerAngles);
                    _Ankle_Right.Add(Ankle_Right.transform.eulerAngles);
                    _Foot_Right.Add(Foot_Right.transform.eulerAngles);

                }

                else if (!isSaving)
                {
                    // create the file, if needed
                    if (!File.Exists(Application.dataPath + "/MovementDataBase/" + "ExpertMovement/" + movementName + ".csv"))
                    {
                        using (StreamWriter writer = File.CreateText(Application.dataPath + "/MovementDataBase/" + "ExpertMovement/" + movementName + ".csv"))
                        {

                            store.Add("Joint1", _Hip_Center);
                            store.Add("Joint2", _Spine);
                            store.Add("Joint3", _Shoulder_Center);
                            store.Add("Joint4", _Shoulder_Left);
                            store.Add("Joint5", _Elbow_Left);
                            store.Add("Joint6", _Wrist_Left);
                            store.Add("Joint7", _Hand_Left);
                            store.Add("Joint8", _Shoulder_Right);
                            store.Add("Joint9", _Elbow_Right);
                            store.Add("Joint10", _Wrist_Right);
                            store.Add("Joint11", _Wrist_Right);
                            store.Add("Joint12", _Hand_Right);
                            store.Add("Joint13", _Hip_Left);
                            store.Add("Joint14", _Knee_Left);
                            store.Add("Joint15", _Ankle_Left);
                            store.Add("Joint16", _Foot_Left);
                            store.Add("Joint17", _Hip_Right);
                            store.Add("Joint18", _Knee_Right);
                            store.Add("Joint19", _Ankle_Right);
                            store.Add("Joint20", _Foot_Right);

                            string[] joints = new[] { "Joint1", "Joint2", "Joint3", "Joint4", "Joint5", "Joint6", "Joint7", "Joint8", "Joint9", "Joint10", "Joint11", "Joint12", "Joint13", "Joint14", "Joint15", "Joint16", "Joint17", "Joint18", "Joint19", "Joint20" };
                           
                            for (int i = 1; i < store["Joint1"].Capacity; i++)
                            {
                                if(i == 0)
                                {
                                    // csv file header
                                    hLine = "time;" +
                                            "HipCenter;HipCenterCoordinates.x;HipCenterCoordinates.y;HipCenterCoordinates.z;" +
                                            "Spine;SpineCoordinates.x;SpineCoordinates.y;SpineCoordinates.z;" +
                                            "ShoulderCenter;ShoulderLeftCoordinates.x;ShoulderLeftCoordinates.y;ShoulderLeftCoordinates.z" +
                                            "Head;HeadCoordinates.x;HeadCoordinates.y;HeadCoordinates.z;" +
                                            "ShoulderLeft;ShoulderLeftCoordinates.x;ShoulderLeftCoordinates.y;ShoulderLeftCoordinates.z;" +
                                            "ElbowLeft;ElbowLeftCoordinates.x;ElbowLeftCoordinates.y;ElbowLeftCoordinates.z;" +
                                            "WristLeft;WristLeftCoordinates.x;WristLeftCoordinates.y;WristLeftCoordinates.z;" +
                                            "HandLeft;HandLeftCoordinates.x;HandLeftCoordinates.y;HandLeftCoordinates.z;" +
                                            "ShoulderRight;ShoulderRightCoordinates.x;ShoulderRightCoordinates.y;ShoulderRightCoordinates.z;" +
                                            "ElbowRight;ElbowRightCoordinates.x;ShoulderRightCoordinates.y;ShoulderRightCoordinates.z;" +
                                            "WristRight;WristRightCoordinates.x;WristRightCoordinates.y;WristRightCoordinates.z;" +
                                            "HandRight;WristRightCoordinates.x;WristRightCoordinates.y;WristRightCoordinates.z;" +
                                            "HipLeft;HipLeftCoordinates.x;HipLeftCoordinates.y;HipLeftCoordinates.z;" +
                                            "KneeLeft;KneeLeftCoordinates.x;KneeLeftCoordinates.y;KneeLeftCoordinates.z;" +
                                            "AnkleLeft;AnkleLeftCoordinates.x;AnkleLeftCoordinates.y;AnkleLeftCoordinates.z;" +
                                            "FootLeft;FootLeftCoordinates.x;FootLeftCoordinates.y;FootLeftCoordinates.z;" +
                                            "HipRight;HipRightCoordinates.x;HipRightCoordinates.y;HipRightCoordinates.z;" +
                                            "KneeRight;KneeRightCoordinates.x;KneeRightCoordinates.y;KneeRightCoordinates.z;" +
                                            "AnkleRight;AnkleRightCoordinates.x;AnkleRightCoordinates.y;AnkleRightCoordinates.z;" +
                                            "FootRight;FootRightCoordinates.x;FootRightCoordinates.y;FootRightCoordinates.z)";
                                    writer.WriteLine(hLine);
                                }

                                string toAppend = null;

                                foreach(string joint in joints)
                                {
                                    List<Vector3> entries = store[joint];
                                    Vector3 entryValue = entries[i];

                                    float entryValueX = entryValue.x;
                                    float entryValueY = entryValue.y;
                                    float entryValueZ = entryValue.z;


                                    toAppend += entryValueX + "; " + entryValueY + "; " + entryValueZ + "; ";

                                }
                                toAppend.Remove(toAppend.Length - 2);
                                //write line to file with timestamp
                                writer.WriteLine(timestamp[i] + "; " + toAppend);
                            }
                        }
                            
                    }
                

                    // check the start time
                    //if (saveStartTime < 0f && manager.IsUserDetected())
                    //{
                    //    saveStartTime = Time.time;
                    //}

                    //if ((secondsToSave == 0f) || ((Time.time - saveStartTime) <= secondsToSave))
                    //{
                    //    using (StreamWriter writer = File.AppendText(Application.dataPath + "/MovementDataBase/" + movementName + ".csv"))
                    //    {
                    //        sLine = string.Format("{0};{1:F3};" +
                    //                                "{2};{3:F3};{4:F3};{5:F3};" +
                    //                                "{6};{7:F3};{8:F3};{9:F3};" +
                    //                                "{10};{11:F3};{12:F3};{13:F3};" +
                    //                                "{14};{15:F3};{16:F3};{17:F3};" +
                    //                                "{18};{19:F3};{20:F3};{21:F3};" +
                    //                                "{22};{23:F3};{24:F3};{25:F3};" +
                    //                                "{26};{27:F3};{28:F3};{29:F3};" +
                    //                                "{30};{31:F3};{32:F3};{33:F3};" +
                    //                                "{34};{35:F3};{36:F3};{37:F3};" +
                    //                                "{38};{39:F3};{40:F3};{41:F3};" +
                    //                                "{42};{43:F3};{44:F3};{45:F3};" +
                    //                                "{46};{47:F3};{48:F3};{49:F3};" +
                    //                                "{50};{51:F3};{52:F3};{53:F3};" +
                    //                                "{54};{55:F3};{56:F3};{57:F3};" +
                    //                                "{58};{59:F3};{60:F3};{61:F3};" +
                    //                                "{62};{63:F3};{64:F3};{65:F3};" +
                    //                                "{66};{67:F3};{68:F3};{69:F3};" +
                    //                                "{70};{71:F3};{72:F3};{73:F3};" +
                    //                                "{74};{75:F3};{76:F3};{77:F3};" +
                    //                                "{78};{79:F3};{80:F3};{81:F3}",
                    //            frame + frameNumber.ToString(),
                    //            Time.time,
                    //            (int)HipCenter, HipCenterCoordinates.x, HipCenterCoordinates.y, HipCenterCoordinates.z,
                    //            (int)Spine, SpineCoordinates.x, SpineCoordinates.y, SpineCoordinates.z,
                    //            (int)ShoulderCenter, ShoulderCenterCoordinates.x, ShoulderCenterCoordinates.y, ShoulderCenterCoordinates.z,
                    //            (int)Head, HeadCoordinates.x, HeadCoordinates.y, HeadCoordinates.z,
                    //            (int)ShoulderLeft, ShoulderLeftCoordinates.x, ShoulderLeftCoordinates.y, ShoulderLeftCoordinates.z,
                    //            (int)ElbowLeft, ElbowLeftCoordinates.x, ElbowLeftCoordinates.y, ElbowLeftCoordinates.z,
                    //            (int)WristLeft, WristLeftCoordinates.x, WristLeftCoordinates.y, WristLeftCoordinates.z,
                    //            (int)HandLeft, HandLeftCoordinates.x, HandLeftCoordinates.y, HandLeftCoordinates.z,
                    //            (int)ShoulderRight, ShoulderRightCoordinates.x, ShoulderRightCoordinates.y, ShoulderRightCoordinates.z,
                    //            (int)ElbowRight, ElbowRightCoordinates.x, ElbowRightCoordinates.y, ElbowRightCoordinates.z,
                    //            (int)WristRight, WristRightCoordinates.x, WristRightCoordinates.y, WristRightCoordinates.z,
                    //            (int)HandRight, HandRightCoordinates.x, HandRightCoordinates.y, HandRightCoordinates.z,
                    //            (int)HipLeft, HipLeftCoordinates.x, HipLeftCoordinates.y, HipLeftCoordinates.z,
                    //            (int)KneeLeft, KneeLeftCoordinates.x, KneeLeftCoordinates.y, KneeLeftCoordinates.z,
                    //            (int)AnkleLeft, AnkleLeftCoordinates.x, AnkleLeftCoordinates.y, AnkleLeftCoordinates.z,
                    //            (int)FootLeft, FootLeftCoordinates.x, FootLeftCoordinates.y, FootLeftCoordinates.z,
                    //            (int)HipRight, HipRightCoordinates.x, HipRightCoordinates.y, HipRightCoordinates.z,
                    //            (int)KneeRight, KneeRightCoordinates.x, KneeRightCoordinates.y, KneeRightCoordinates.z,
                    //            (int)AnkleRight, AnkleRightCoordinates.x, AnkleRightCoordinates.y, AnkleRightCoordinates.z,
                    //            (int)FootRight, FootRightCoordinates.x, FootRightCoordinates.y, FootRightCoordinates.z);

                    //        //sLine.Remove(sLine.Length - 2);// <-- check this
                    //        writer.WriteLine(sLine);
                    //        frameNumber++;
                    //    }
                    //}
                }
            }
        }
    }
}
