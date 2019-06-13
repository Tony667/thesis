using UnityEngine;

[System.Serializable]
public class DataToSave
{
    // the joint we want to track
    public KinectWrapper.NuiSkeletonPositionIndex HipCenter = KinectWrapper.NuiSkeletonPositionIndex.HipCenter;
    public KinectWrapper.NuiSkeletonPositionIndex Spine = KinectWrapper.NuiSkeletonPositionIndex.Spine;
    public KinectWrapper.NuiSkeletonPositionIndex ShoulderCenter = KinectWrapper.NuiSkeletonPositionIndex.ShoulderCenter;
    public KinectWrapper.NuiSkeletonPositionIndex Head = KinectWrapper.NuiSkeletonPositionIndex.Head;
    public KinectWrapper.NuiSkeletonPositionIndex ShoulderLeft = KinectWrapper.NuiSkeletonPositionIndex.ShoulderLeft;
    public KinectWrapper.NuiSkeletonPositionIndex ElbowLeft = KinectWrapper.NuiSkeletonPositionIndex.ElbowLeft;
    public KinectWrapper.NuiSkeletonPositionIndex WristLeft = KinectWrapper.NuiSkeletonPositionIndex.WristLeft;
    public KinectWrapper.NuiSkeletonPositionIndex HandLeft = KinectWrapper.NuiSkeletonPositionIndex.HandLeft;
    public KinectWrapper.NuiSkeletonPositionIndex ShoulderRight = KinectWrapper.NuiSkeletonPositionIndex.ShoulderRight;
    public KinectWrapper.NuiSkeletonPositionIndex ElbowRight = KinectWrapper.NuiSkeletonPositionIndex.ElbowRight;
    public KinectWrapper.NuiSkeletonPositionIndex WristRight = KinectWrapper.NuiSkeletonPositionIndex.WristRight;
    public KinectWrapper.NuiSkeletonPositionIndex HandRight = KinectWrapper.NuiSkeletonPositionIndex.WristRight;
    public KinectWrapper.NuiSkeletonPositionIndex HipLeft = KinectWrapper.NuiSkeletonPositionIndex.HipLeft;
    public KinectWrapper.NuiSkeletonPositionIndex KneeLeft = KinectWrapper.NuiSkeletonPositionIndex.KneeLeft;
    public KinectWrapper.NuiSkeletonPositionIndex AnkleLeft = KinectWrapper.NuiSkeletonPositionIndex.AnkleLeft;
    public KinectWrapper.NuiSkeletonPositionIndex FootLeft = KinectWrapper.NuiSkeletonPositionIndex.FootLeft;
    public KinectWrapper.NuiSkeletonPositionIndex HipRight = KinectWrapper.NuiSkeletonPositionIndex.HipRight;
    public KinectWrapper.NuiSkeletonPositionIndex KneeRight = KinectWrapper.NuiSkeletonPositionIndex.KneeRight;
    public KinectWrapper.NuiSkeletonPositionIndex AnkleRight = KinectWrapper.NuiSkeletonPositionIndex.AnkleRight;
    public KinectWrapper.NuiSkeletonPositionIndex FootRight = KinectWrapper.NuiSkeletonPositionIndex.FootRight;

    // joint coordinates in 3D space
    public Vector3 HipCenterCoordinates;
    public Vector3 SpineCoordinates;
    public Vector3 ShoulderCenterCoordinates;
    public Vector3 HeadCoordinates;
    public Vector3 ShoulderLeftCoordinates;
    public Vector3 ElbowLeftCoordinates;
    public Vector3 WristLeftCoordinates;
    public Vector3 HandLeftCoordinates;
    public Vector3 ShoulderRightCoordinates;
    public Vector3 ElbowRightCoordinates;
    public Vector3 WristRightCoordinates;
    public Vector3 HandRightCoordinates;
    public Vector3 HipLeftCoordinates;
    public Vector3 KneeLeftCoordinates;
    public Vector3 AnkleLeftCoordinates;
    public Vector3 FootLeftCoordinates;
    public Vector3 HipRightCoordinates;
    public Vector3 KneeRightCoordinates;
    public Vector3 AnkleRightCoordinates;
    public Vector3 FootRightCoordinates;
}
