using UnityEngine;
using System.Collections;
using System.IO;

public class SavingLoadingSystem : MonoBehaviour
{   
    // the joint we want to track
    private KinectWrapper.NuiSkeletonPositionIndex HipCenter = KinectWrapper.NuiSkeletonPositionIndex.HipCenter;
    private KinectWrapper.NuiSkeletonPositionIndex Spine = KinectWrapper.NuiSkeletonPositionIndex.Spine;
    private KinectWrapper.NuiSkeletonPositionIndex ShoulderCenter = KinectWrapper.NuiSkeletonPositionIndex.ShoulderCenter;
    private KinectWrapper.NuiSkeletonPositionIndex Head = KinectWrapper.NuiSkeletonPositionIndex.Head;
    private KinectWrapper.NuiSkeletonPositionIndex ShoulderLeft = KinectWrapper.NuiSkeletonPositionIndex.ShoulderLeft;
    private KinectWrapper.NuiSkeletonPositionIndex ElbowLeft = KinectWrapper.NuiSkeletonPositionIndex.ElbowLeft;
    private KinectWrapper.NuiSkeletonPositionIndex WristLeft = KinectWrapper.NuiSkeletonPositionIndex.WristLeft;
    private KinectWrapper.NuiSkeletonPositionIndex HandLeft = KinectWrapper.NuiSkeletonPositionIndex.HandLeft;
    private KinectWrapper.NuiSkeletonPositionIndex ShoulderRight = KinectWrapper.NuiSkeletonPositionIndex.ShoulderRight;
    private KinectWrapper.NuiSkeletonPositionIndex ElbowRight = KinectWrapper.NuiSkeletonPositionIndex.ElbowRight;
    private KinectWrapper.NuiSkeletonPositionIndex WristRight = KinectWrapper.NuiSkeletonPositionIndex.WristRight;
    private KinectWrapper.NuiSkeletonPositionIndex HandRight = KinectWrapper.NuiSkeletonPositionIndex.WristRight;
    private KinectWrapper.NuiSkeletonPositionIndex HipLeft = KinectWrapper.NuiSkeletonPositionIndex.HipLeft;
    private KinectWrapper.NuiSkeletonPositionIndex KneeLeft = KinectWrapper.NuiSkeletonPositionIndex.KneeLeft;
    private KinectWrapper.NuiSkeletonPositionIndex AnkleLeft = KinectWrapper.NuiSkeletonPositionIndex.AnkleLeft;
    private KinectWrapper.NuiSkeletonPositionIndex FootLeft = KinectWrapper.NuiSkeletonPositionIndex.FootLeft;
    private KinectWrapper.NuiSkeletonPositionIndex HipRight = KinectWrapper.NuiSkeletonPositionIndex.HipRight;
    private KinectWrapper.NuiSkeletonPositionIndex KneeRight = KinectWrapper.NuiSkeletonPositionIndex.KneeRight;
    private KinectWrapper.NuiSkeletonPositionIndex AnkleRight = KinectWrapper.NuiSkeletonPositionIndex.AnkleRight;
    private KinectWrapper.NuiSkeletonPositionIndex FootRight = KinectWrapper.NuiSkeletonPositionIndex.FootRight;

    // joint coordinates in 3D space
    private Vector3 HipCenterCoordinates;
    private Vector3 SpineCoordinates;
    private Vector3 ShoulderCenterCoordinates;
    private Vector3 HeadCoordinates;
    private Vector3 ShoulderLeftCoordinates;
    private Vector3 ElbowLeftCoordinates;
    private Vector3 WristLeftCoordinates;
    private Vector3 HandLeftCoordinates;
    private Vector3 ShoulderRightCoordinates;
    private Vector3 ElbowRightCoordinates;
    private Vector3 WristRightCoordinates;
    private Vector3 HandRightCoordinates;
    private Vector3 HipLeftCoordinates;
    private Vector3 KneeLeftCoordinates;
    private Vector3 AnkleLeftCoordinates;
    private Vector3 FootLeftCoordinates;
    private Vector3 HipRightCoordinates;
    private Vector3 KneeRightCoordinates;
    private Vector3 AnkleRightCoordinates;
    private Vector3 FootRightCoordinates;

    // joint position at the moment, in Kinect coordinates
    //public Vector3 outputPosition;

	// if it is saving data to a csv file or not
	public bool isSaving = false;

    // if it is loading data from a csv file or not
    public bool isLoading = false;

	// how many seconds to save data into the csv file, or 0 to save non-stop
	public float secondsToSave = 0f;

	// path to the csv file (;-limited)
	public string movementName;

    public string movementToLoad;

    // start time of data saving to csv file
    private float saveStartTime = -1f;

    // get the joint position
    KinectManager manager;

    string sLine;

    private void Awake()
    {
        MovementDataBasePathCheck.Init();
       
        // get the joint position
        manager = KinectManager.Instance;

        movementToLoad = Application.dataPath + "/MovementDataBase/" + movementName + ".csv";
    }


    void Update () 
	{


        if (manager && manager.IsInitialized())
		{
			if(manager.IsUserDetected())
			{
				uint userId = manager.GetPlayer1ID();

                // output the joint position for easy tracking
                HipCenterCoordinates = manager.GetJointPosition(userId, (int)HipCenter);
                SpineCoordinates = manager.GetJointPosition(userId, (int)Spine);
                ShoulderCenterCoordinates = manager.GetJointPosition(userId, (int)ShoulderCenter);
                HeadCoordinates = manager.GetJointPosition(userId, (int)Head);
                ShoulderLeftCoordinates = manager.GetJointPosition(userId, (int)ShoulderLeft);
                ElbowLeftCoordinates = manager.GetJointPosition(userId, (int)ElbowLeft);
                WristLeftCoordinates = manager.GetJointPosition(userId, (int)WristLeft);
                HandLeftCoordinates = manager.GetJointPosition(userId, (int)HandLeft);
                ShoulderRightCoordinates = manager.GetJointPosition(userId, (int)ShoulderRight);
                ElbowRightCoordinates = manager.GetJointPosition(userId, (int)ElbowRight);
                WristRightCoordinates = manager.GetJointPosition(userId, (int)WristRight);
                HandRightCoordinates = manager.GetJointPosition(userId, (int)HandRight);
                HipLeftCoordinates = manager.GetJointPosition(userId, (int)HipLeft);
                KneeLeftCoordinates = manager.GetJointPosition(userId, (int)KneeLeft);
                AnkleLeftCoordinates = manager.GetJointPosition(userId, (int)AnkleLeft);
                FootLeftCoordinates = manager.GetJointPosition(userId, (int)FootLeft);
                HipRightCoordinates = manager.GetJointPosition(userId, (int)HipRight);
                KneeRightCoordinates = manager.GetJointPosition(userId, (int)KneeRight);
                AnkleRightCoordinates = manager.GetJointPosition(userId, (int)AnkleRight);
                FootRightCoordinates = manager.GetJointPosition(userId, (int)FootRight);

                //Vector3 jointPos = manager.GetJointPosition(userId, (int)joint);
				//outputPosition = jointPos;

				if(isSaving)
				{
                    // create the file, if needed
                    if (!File.Exists(Application.dataPath + "/MovementDataBase/" + movementName + ".csv"))
                    {
                        using (StreamWriter writer = File.CreateText(Application.dataPath + "/MovementDataBase/" + movementName + ".csv"))
                        {
                            // csv file header
                            sLine = "time;" +
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
                            writer.WriteLine(sLine);
                        }
                    }

                    // check the start time
                    if (saveStartTime < 0f)
                    {
                        saveStartTime = Time.time;
                    }

                    if ((secondsToSave == 0f) || ((Time.time - saveStartTime) <= secondsToSave))
					{
						using(StreamWriter writer = File.AppendText(Application.dataPath + "/MovementDataBase/" + movementName + ".csv"))
						{
                            sLine = string.Format("{0:F3};{1};{2:F3};{3:F3};{4:F3};" +
                                                        "{5};{6:F3};{7:F3};{8:F3};" +
                                                        "{9};{10:F3};{11:F3};{12:F3};" +
                                                        "{13};{14:F3};{15:F3};{16:F3};" +
                                                        "{17};{18:F3};{19:F3};{20:F3};" +
                                                        "{21};{22:F3};{23:F3};{24:F3};" +
                                                        "{25};{26:F3};{27:F3};{28:F3};" +
                                                        "{29};{30:F3};{31:F3};{32:F3};" +
                                                        "{33};{34:F3};{35:F3};{36:F3};" +
                                                        "{37};{38:F3};{39:F3};{40:F3};" +
                                                        "{41};{42:F3};{43:F3};{44:F3};" +
                                                        "{45};{46:F3};{47:F3};{48:F3};" +
                                                        "{49};{50:F3};{51:F3};{52:F3};" +
                                                        "{53};{54:F3};{55:F3};{56:F3};" +
                                                        "{57};{58:F3};{59:F3};{60:F3};" +
                                                        "{61};{62:F3};{63:F3};{64:F3};" +
                                                        "{65};{66:F3};{67:F3};{68:F3};" +
                                                        "{69};{70:F3};{71:F3};{72:F3};" +
                                                        "{73};{74:F3};{75:F3};{76:F3};" +
                                                        "{77};{78:F3};{79:F3};{80:F3}",
                                Time.time,
                                (int)HipCenter, HipCenterCoordinates.x, HipCenterCoordinates.y, HipCenterCoordinates.z,
                                (int)Spine, SpineCoordinates.x, SpineCoordinates.y, SpineCoordinates.z,
                                (int)ShoulderCenter, ShoulderLeftCoordinates.x, ShoulderLeftCoordinates.y, ShoulderLeftCoordinates.z,
                                (int)Head, HeadCoordinates.x, HeadCoordinates.y, HeadCoordinates.z,
                                (int)ShoulderLeft, ShoulderLeftCoordinates.x, ShoulderLeftCoordinates.y, ShoulderLeftCoordinates.z,
                                (int)ElbowLeft, ElbowLeftCoordinates.x, ElbowLeftCoordinates.y, ElbowLeftCoordinates.z,
                                (int)WristLeft, WristLeftCoordinates.x, WristLeftCoordinates.y, WristLeftCoordinates.z,
                                (int)HandLeft, HandLeftCoordinates.x, HandLeftCoordinates.y, HandLeftCoordinates.z,
                                (int)ShoulderRight, ShoulderRightCoordinates.x, ShoulderRightCoordinates.y, ShoulderRightCoordinates.z,
                                (int)ElbowRight, ElbowRightCoordinates.x, ShoulderRightCoordinates.y, ShoulderRightCoordinates.z,
                                (int)WristRight, WristRightCoordinates.x, WristRightCoordinates.y, WristRightCoordinates.z,
                                (int)HandRight, WristRightCoordinates.x, WristRightCoordinates.y, WristRightCoordinates.z,
                                (int)HipLeft, HipLeftCoordinates.x, HipLeftCoordinates.y, HipLeftCoordinates.z,
                                (int)KneeLeft, KneeLeftCoordinates.x, KneeLeftCoordinates.y, KneeLeftCoordinates.z,
                                (int)AnkleLeft, AnkleLeftCoordinates.x, AnkleLeftCoordinates.y, AnkleLeftCoordinates.z,
                                (int)FootLeft, FootLeftCoordinates.x, FootLeftCoordinates.y, FootLeftCoordinates.z,
                                (int)HipRight, HipRightCoordinates.x, HipRightCoordinates.y, HipRightCoordinates.z,
                                (int)KneeRight, KneeRightCoordinates.x, KneeRightCoordinates.y, KneeRightCoordinates.z,
                                (int)AnkleRight, AnkleRightCoordinates.x, AnkleRightCoordinates.y, AnkleRightCoordinates.z,
                                (int)FootRight, FootRightCoordinates.x, FootRightCoordinates.y, FootRightCoordinates.z);

							writer.WriteLine(sLine);
						}
					}
				}
			}
		}

        if (isLoading)
        {
            if(File.Exists(Application.dataPath + "/MovementDataBase/" + movementName + ".csv"))
            {
                using (StreamReader reader = File.OpenText(movementToLoad))
                {
                    while ((movementToLoad = reader.ReadLine()) != null)
                    {
                        Debug.Log(movementToLoad);
                    }
                }
            }
        }
    }
}
