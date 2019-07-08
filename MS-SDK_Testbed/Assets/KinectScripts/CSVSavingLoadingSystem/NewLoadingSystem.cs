using System.Collections;
using UnityEngine;

namespace CsvNameSpace
{

    public class GetterSetter
    {

        public bool animate;
        public bool Animate {
            get { return animate; }
            set { animate = true; }
        }
    }

    public class NewLoadingSystem : MonoBehaviour
    {



        public string[] fieldsNext;
        public string[] fields;
        //  public GameObject armature;
        public TextAsset csvFile;
        // public GameObject forearm;
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

        // Update is called once per frame
        int i = 0;
        long previoustime = 0;

        void Update()
        {
            StartCoroutine(SetAngles());
            i++;

        }
        IEnumerator SetAngles()
        {
            print("Time " + Time.time);
            if (i >= 0)
            {
                string[] records = csvFile.text.Split('\n');

                if (i < records.Length - 2)
                {
                    fields = records[i].Split(';');
                    fieldsNext = records[i + 1].Split(';');
                }
                else
                {
                    //restart when reached the end of file and no more rows are remaining
                    //   print("i = " + i + " length = " + records.Length);
                    //ignore first row as that contains headings and not data
                    i = 1;
                    //looks at current row of data
                    fields = records[i].Split(';');
                    //looks at the next row of data
                    fieldsNext = records[i + 1].Split(';');
                }
                //each joint angle is transformed from the data in the CSV file

                Hip_Center.transform.eulerAngles = new Vector3(float.Parse(fields[1]), float.Parse(fields[2]), float.Parse(fields[3]));
                Spine.transform.eulerAngles = new Vector3(float.Parse(fields[4]), float.Parse(fields[5]), float.Parse(fields[6]));
                Shoulder_Center.transform.eulerAngles = new Vector3(float.Parse(fields[7]), float.Parse(fields[8]), float.Parse(fields[9]));
                Head.transform.eulerAngles = new Vector3(float.Parse(fields[10]), float.Parse(fields[11]), float.Parse(fields[12]));
                Shoulder_Left.transform.eulerAngles = new Vector3(float.Parse(fields[13]), float.Parse(fields[14]), float.Parse(fields[15]));
                Elbow_Left.transform.eulerAngles = new Vector3(float.Parse(fields[16]), float.Parse(fields[17]), float.Parse(fields[18]));
                Wrist_Left.transform.eulerAngles = new Vector3(float.Parse(fields[16]), float.Parse(fields[17]), float.Parse(fields[18]));
                Hand_Left.transform.eulerAngles = new Vector3(float.Parse(fields[19]), float.Parse(fields[20]), float.Parse(fields[21]));
                Shoulder_Right.transform.eulerAngles = new Vector3(float.Parse(fields[22]), float.Parse(fields[23]), float.Parse(fields[24]));
                Elbow_Right.transform.eulerAngles = new Vector3(float.Parse(fields[25]), float.Parse(fields[26]), float.Parse(fields[27]));
                Wrist_Right.transform.eulerAngles = new Vector3(float.Parse(fields[28]), float.Parse(fields[29]), float.Parse(fields[30]));
                Hand_Left.transform.eulerAngles = new Vector3(float.Parse(fields[31]), float.Parse(fields[32]), float.Parse(fields[33]));
                Hip_Left.transform.eulerAngles = new Vector3(float.Parse(fields[34]), float.Parse(fields[35]), float.Parse(fields[36]));
                Knee_Left.transform.eulerAngles = new Vector3(float.Parse(fields[37]), float.Parse(fields[38]), float.Parse(fields[39]));
                Ankle_Left.transform.eulerAngles = new Vector3(float.Parse(fields[40]), float.Parse(fields[41]), float.Parse(fields[42]));
                Foot_Left.transform.eulerAngles = new Vector3(float.Parse(fields[43]), float.Parse(fields[44]), float.Parse(fields[45]));
                Hip_Right.transform.eulerAngles = new Vector3(float.Parse(fields[46]), float.Parse(fields[47]), float.Parse(fields[48]));
                Knee_Right.transform.eulerAngles = new Vector3(float.Parse(fields[49]), float.Parse(fields[50]), float.Parse(fields[51]));
                Ankle_Right.transform.eulerAngles = new Vector3(float.Parse(fields[52]), float.Parse(fields[53]), float.Parse(fields[54]));
                Foot_Right.transform.eulerAngles = new Vector3(float.Parse(fields[55]), float.Parse(fields[56]), float.Parse(fields[57]));
                

                long currentTime = long.Parse(fields[0]);
                long nextTime = long.Parse(fieldsNext[0]);

                //calculate the delay required between the current timestamp of frame and the previous timestamp 
                yield return new WaitForSeconds(nextTime - currentTime);
                //now simulates animation in real time

            }
        }
    }
}