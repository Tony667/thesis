using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class JSONSavingSystem : MonoBehaviour
{

    DataToSave dataToSave = new DataToSave();
    KinectManager manager;

    // if it is saving data to a csv file or not
    public bool isSaving = false;

    // path to the csv file (;-limited)
    public string movementName;

    private string contents;

    private void Awake()
    {
        MovementDataBasePathCheck.Init();

        // get the joint position
        manager = KinectManager.Instance;
        Debug.Log("in awake");
    }

    public void Update()
    {
        if (manager && manager.IsInitialized())
        {
            Debug.Log("in update");

            if (manager.IsUserDetected())
            {
                uint userId = manager.GetPlayer1ID();

                //dataToSave = new DataToSave();

                dataToSave.HipCenterCoordinates = manager.GetJointPosition(userId, (int)dataToSave.HipCenter);
                dataToSave.SpineCoordinates = manager.GetJointPosition(userId, (int)dataToSave.Spine);
                dataToSave.ShoulderCenterCoordinates = manager.GetJointPosition(userId, (int)dataToSave.ShoulderCenter);
                dataToSave.HeadCoordinates = manager.GetJointPosition(userId, (int)dataToSave.Head);
                dataToSave.ShoulderLeftCoordinates = manager.GetJointPosition(userId, (int)dataToSave.ShoulderLeft);
                dataToSave.ElbowLeftCoordinates = manager.GetJointPosition(userId, (int)dataToSave.ElbowLeft);
                dataToSave.WristLeftCoordinates = manager.GetJointPosition(userId, (int)dataToSave.WristLeft);
                dataToSave.HandLeftCoordinates = manager.GetJointPosition(userId, (int)dataToSave.HandLeft);
                dataToSave.ShoulderRightCoordinates = manager.GetJointPosition(userId, (int)dataToSave.ShoulderRight);
                dataToSave.ElbowRightCoordinates = manager.GetJointPosition(userId, (int)dataToSave.ElbowRight);
                dataToSave.WristRightCoordinates = manager.GetJointPosition(userId, (int)dataToSave.WristRight);
                dataToSave.HandRightCoordinates = manager.GetJointPosition(userId, (int)dataToSave.HandRight);
                dataToSave.HipLeftCoordinates = manager.GetJointPosition(userId, (int)dataToSave.HipLeft);
                dataToSave.KneeLeftCoordinates = manager.GetJointPosition(userId, (int)dataToSave.KneeLeft);
                dataToSave.AnkleLeftCoordinates = manager.GetJointPosition(userId, (int)dataToSave.AnkleLeft);
                dataToSave.FootLeftCoordinates = manager.GetJointPosition(userId, (int)dataToSave.FootLeft);
                dataToSave.HipRightCoordinates = manager.GetJointPosition(userId, (int)dataToSave.HipRight);
                dataToSave.KneeRightCoordinates = manager.GetJointPosition(userId, (int)dataToSave.KneeRight);
                dataToSave.AnkleRightCoordinates = manager.GetJointPosition(userId, (int)dataToSave.AnkleRight);
                dataToSave.FootRightCoordinates = manager.GetJointPosition(userId, (int)dataToSave.FootRight);

                if (isSaving)
                {
                    //for (int i = 0; i -1 < i++; i++)
                    //{
                        //Debug.Log(i);
                        Debug.Log(Application.dataPath + "/MovementDataBase/" + movementName /*+ "/" + "frame" + i */+ ".json");

                        // create the file, if needed
                        if (!File.Exists(Application.dataPath + "/MovementDataBase/" + movementName /*+ "/" + "frame" + i.ToString()*/ + ".json"))
                        {
                            
                            //contents = JsonConverter.SerializeObject(dataToSave);

                            //Debug.Log("in !file.exists");
                            //contents = JsonUtility.ToJson(dataToSave, true);
                            //FileInfo file = new FileInfo(Application.dataPath + "/MovementDataBase/" + movementName /*+ "/" + "frame" + i.ToString()*/ + ".json");
                            //file.Directory.Create();
                            //File.WriteAllText(Application.dataPath + "/MovementDataBase/" + movementName /*+ "/" + "frame" + i.ToString()*/ + ".json", contents);
                            //using (StreamWriter writer = File.AppendText(Application.dataPath + "/MovementDataBase/" + movementName /*+ "/" + "frame" + i.ToString()*/ + ".json"))
                            //{
                            //    writer.WriteLine(contents);
                            //}
                            //i++;
                        }
                    //}
                }       
            }
        }
    }

    //void Save()
    //{
    //    contents = JsonUtility.ToJson(dataToSave, true);
    //    File.WriteAllText(Application.dataPath + "/MovementDataBase/" + movementName + "/" + "frame" + i + ".json", contents);
    //}
}
