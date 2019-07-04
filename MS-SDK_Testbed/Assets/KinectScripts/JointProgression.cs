using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JointProgression
{
    private double[] expertMovementHipCenter;
    private double[] expertMovementSpine;
    private double[] expertMovementNeck;
    private double[] expertMovementHead;
    private double[] expertMovementShoulderCenter;
    private double[] expertMovementShoulderLeft;
    private double[] expertMovementElbowLeft;
    private double[] expertMovementWristLeft;
    private double[] expertMovementHandLeft;
    private double[] expertMovementShoulderRight;
    private double[] expertMovemenElbowRight;
    private double[] expertMovementWristRight;
    private double[] expertMovementHandRight;
    private double[] expertMovementHipLeft;
    private double[] expertMovementKneeLeft;
    private double[] expertMovementAnkcleLeft;
    private double[] expertMovementFootLeft;
    private double[] expertMovementHipRight;
    private double[] expertMovementKneeRight;
    private double[] expertMovementAnckleRight;
    private double[] expertMovementFootRight;

    private double[] amatureMovementHipCenter;
    private double[] amatureMovementSpine;
    private double[] amatureMovementNeck;
    private double[] amatureMovementShoulderCenter;
    private double[] amatureMovementShoulderLeft;
    private double[] amatureMovementElbowLeft;
    private double[] amatureMovementWristLeft;
    private double[] amatureMovementHandLeft;
    private double[] amatureMovementShoulderRight;
    private double[] amatureMovementElbowRight;
    private double[] amatureMovementHandRight;
    private double[] amatureMovementHipLeft;
    private double[] amatureMovementKneeLeft;
    private double[] amatureMovementAnkcleLeft;
    private double[] amatureMovementFootLeft;
    private double[] amatureMovementHipRight;
    private double[] amatureMovementKneeRight;
    private double[] amatureMovementAnkcleRight;
    private double[] amatureMovementFootRight;

    public List<double> expertJoint0 = new List<double>();
    public List<double> expertJoint1 = new List<double>();
    public List<double> expertJoint2 = new List<double>();
    public List<double> expertJoint3 = new List<double>();
    public List<double> expertJoint4 = new List<double>();
    public List<double> expertJoint5 = new List<double>();
    public List<double> expertJoint6 = new List<double>();
    public List<double> expertJoint7 = new List<double>();
    public List<double> expertJoint8 = new List<double>();
    public List<double> expertJoint9 = new List<double>();
    public List<double> expertJoint10 = new List<double>();
    public List<double> expertJoint11 = new List<double>();
    public List<double> expertJoint12 = new List<double>();
    public List<double> expertJoint13 = new List<double>();
    public List<double> expertJoint14 = new List<double>();
    public List<double> expertJoint15 = new List<double>();
    public List<double> expertJoint16 = new List<double>();
    public List<double> expertJoint17 = new List<double>();
    public List<double> expertJoint18 = new List<double>();
    public List<double> expertJoint19 = new List<double>();

    public List<double> amatureJoint0 = new List<double>();
    public List<double> amatureJoint1 = new List<double>();
    public List<double> amatureJoint2 = new List<double>();
    public List<double> amatureJoint3 = new List<double>();
    public List<double> amatureJoint4 = new List<double>();
    public List<double> amatureJoint5 = new List<double>();
    public List<double> amatureJoint6 = new List<double>();
    public List<double> amatureJoint7 = new List<double>();
    public List<double> amatureJoint8 = new List<double>();
    public List<double> amatureJoint9 = new List<double>();
    public List<double> amatureJoint10 = new List<double>();
    public List<double> amatureJoint11 = new List<double>();
    public List<double> amatureJoint12 = new List<double>();
    public List<double> amatureJoint13 = new List<double>();
    public List<double> amatureJoint14 = new List<double>();
    public List<double> amatureJoint15 = new List<double>();
    public List<double> amatureJoint16 = new List<double>();
    public List<double> amatureJoint17 = new List<double>();
    public List<double> amatureJoint18 = new List<double>();
    public List<double> amatureJoint19 = new List<double>();

    public void JointProgressionExpert()
    {
        expertMovementHipCenter = expertJoint0.ToArray();
        //continue
    }

    public void JointProgressionAmature()
    {
        amatureMovementHipCenter = amatureJoint0.ToArray();
        //continue
    }
}
