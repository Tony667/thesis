using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class LoadingSystem : MonoBehaviour
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

    // if it is loading data from a csv file or not
    public bool isLoading = false;

    // path to the csv file
    public string movementToLoad;

    private string[] sLine;

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
                        sLine = movementToLoad.Split(';');
                        HipCenterCoordinates.x = float.Parse(sLine[2]);
                        Debug.Log(HipCenterCoordinates.x);
                    }
                }
            }
        }
    }
}
