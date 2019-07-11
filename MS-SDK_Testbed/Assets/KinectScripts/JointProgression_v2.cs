using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class JointProgression_v2 
{
    protected double[] jointProgX;
    protected double[] jointProgY;
    protected double[] jointProgZ;

    protected List<double> jointXList = new List<double>();
    protected List<double> jointYList = new List<double>();
    protected List<double> jointZList = new List<double>();

    public JointProgression_v2(double x, double y, double z)
    {
        jointXList.Add(x);
        jointYList.Add(y);
        jointZList.Add(z);
    }

    public void ListToArray()
    {
        jointProgX = jointXList.ToArray();
        jointProgY = jointYList.ToArray();
        jointProgZ = jointZList.ToArray();
    }
}
