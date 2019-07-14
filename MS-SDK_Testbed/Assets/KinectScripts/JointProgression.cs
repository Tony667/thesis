using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JointProgression
{
    private double[] expertMovementHipCenterX;
    private double[] expertMovementHipCenterY;
    private double[] expertMovementHipCenterZ;
    private double[] expertMovementSpineX;
    private double[] expertMovementSpineY;
    private double[] expertMovementSpineZ;
    private double[] expertMovementShoulderCenterX;
    private double[] expertMovementShoulderCenterY;
    private double[] expertMovementShoulderCenterZ;
    private double[] expertMovementHeadX;
    private double[] expertMovementHeadY;
    private double[] expertMovementHeadZ;
    private double[] expertMovementShoulderLeftX;
    private double[] expertMovementShoulderLeftY;
    private double[] expertMovementShoulderLeftZ;
    private double[] expertMovementElbowLeftX;
    private double[] expertMovementElbowLeftY;
    private double[] expertMovementElbowLeftZ;
    private double[] expertMovementWristLeftX;
    private double[] expertMovementWristLeftY;
    private double[] expertMovementWristLeftZ;
    private double[] expertMovementHandLeftX;
    private double[] expertMovementHandLeftY;
    private double[] expertMovementHandLeftZ;
    private double[] expertMovementShoulderRightX;
    private double[] expertMovementShoulderRightY;
    private double[] expertMovementShoulderRightZ;
    private double[] expertMovemenElbowRightX;
    private double[] expertMovemenElbowRightY;
    private double[] expertMovemenElbowRightZ;
    private double[] expertMovementWristRightX;
    private double[] expertMovementWristRightY;
    private double[] expertMovementWristRightZ;
    private double[] expertMovementHandRightX;
    private double[] expertMovementHandRightY;
    private double[] expertMovementHandRightZ;
    private double[] expertMovementHipLeftX;
    private double[] expertMovementHipLeftY;
    private double[] expertMovementHipLeftZ;
    private double[] expertMovementKneeLeftX;
    private double[] expertMovementKneeLeftY;
    private double[] expertMovementKneeLeftZ;
    private double[] expertMovementAnkcleLeftX;
    private double[] expertMovementAnkcleLeftY;
    private double[] expertMovementAnkcleLeftZ;
    private double[] expertMovementFootLeftX;
    private double[] expertMovementFootLeftY;
    private double[] expertMovementFootLeftZ;
    private double[] expertMovementHipRightX;
    private double[] expertMovementHipRightY;
    private double[] expertMovementHipRightZ;
    private double[] expertMovementKneeRightX;
    private double[] expertMovementKneeRightY;
    private double[] expertMovementKneeRightZ;
    private double[] expertMovementAnckleRightX;
    private double[] expertMovementAnckleRightY;
    private double[] expertMovementAnckleRightZ;
    private double[] expertMovementFootRightX;
    private double[] expertMovementFootRightY;
    private double[] expertMovementFootRightZ;

    private double[] amatureMovementHipCenterX;
    private double[] amatureMovementHipCenterY;
    private double[] amatureMovementHipCenterZ;
    private double[] amatureMovementSpineX;
    private double[] amatureMovementSpineY;
    private double[] amatureMovementSpineZ;
    private double[] amatureMovementShoulderCenterX;
    private double[] amatureMovementShoulderCenterY;
    private double[] amatureMovementShoulderCenterZ;
    private double[] amatureMovementHeadX;
    private double[] amatureMovementHeadY;
    private double[] amatureMovementHeadZ;
    private double[] amatureMovementShoulderLeftX;
    private double[] amatureMovementShoulderLeftY;
    private double[] amatureMovementShoulderLeftZ;
    private double[] amatureMovementElbowLeftX;
    private double[] amatureMovementElbowLeftY;
    private double[] amatureMovementElbowLeftZ;
    private double[] amatureMovementWristLeftX;
    private double[] amatureMovementWristLeftY;
    private double[] amatureMovementWristLeftZ;
    private double[] amatureMovementHandLeftX;
    private double[] amatureMovementHandLeftY;
    private double[] amatureMovementHandLeftZ;
    private double[] amatureMovementShoulderRightX;
    private double[] amatureMovementShoulderRightY;
    private double[] amatureMovementShoulderRightZ;
    private double[] amatureMovementElbowRightX;
    private double[] amatureMovementElbowRightY;
    private double[] amatureMovementElbowRightZ;
    private double[] amatureMovementWristRightX;
    private double[] amatureMovementWristRightY;
    private double[] amatureMovementWristRightZ;
    private double[] amatureMovementHandRightX;
    private double[] amatureMovementHandRightY;
    private double[] amatureMovementHandRightZ;
    private double[] amatureMovementHipLeftX;
    private double[] amatureMovementHipLeftY;
    private double[] amatureMovementHipLeftZ;
    private double[] amatureMovementKneeLeftX;
    private double[] amatureMovementKneeLeftY;
    private double[] amatureMovementKneeLeftZ;
    private double[] amatureMovementAnkcleLeftX;
    private double[] amatureMovementAnkcleLeftY;
    private double[] amatureMovementAnkcleLeftZ;
    private double[] amatureMovementFootLeftX;
    private double[] amatureMovementFootLeftY;
    private double[] amatureMovementFootLeftZ;
    private double[] amatureMovementHipRightX;
    private double[] amatureMovementHipRightY;
    private double[] amatureMovementHipRightZ;
    private double[] amatureMovementKneeRightX;
    private double[] amatureMovementKneeRightY;
    private double[] amatureMovementKneeRightZ;
    private double[] amatureMovementAnkcleRightX;
    private double[] amatureMovementAnkcleRightY;
    private double[] amatureMovementAnkcleRightZ;
    private double[] amatureMovementFootRightX;
    private double[] amatureMovementFootRightY;
    private double[] amatureMovementFootRightZ;

    public List<double> expertJoint0X = new List<double>();
    public List<double> expertJoint0Y = new List<double>();
    public List<double> expertJoint0Z = new List<double>();
    public List<double> expertJoint1X = new List<double>();
    public List<double> expertJoint1Y = new List<double>();
    public List<double> expertJoint1Z = new List<double>();
    public List<double> expertJoint2X = new List<double>();
    public List<double> expertJoint2Y = new List<double>();
    public List<double> expertJoint2Z = new List<double>();
    public List<double> expertJoint3X = new List<double>();
    public List<double> expertJoint3Y = new List<double>();
    public List<double> expertJoint3Z = new List<double>();
    public List<double> expertJoint4X = new List<double>();
    public List<double> expertJoint4Y = new List<double>();
    public List<double> expertJoint4Z = new List<double>();
    public List<double> expertJoint5X = new List<double>();
    public List<double> expertJoint5Y = new List<double>();
    public List<double> expertJoint5Z = new List<double>();
    public List<double> expertJoint6X = new List<double>();
    public List<double> expertJoint6Y = new List<double>();
    public List<double> expertJoint6Z = new List<double>();
    public List<double> expertJoint7X = new List<double>();
    public List<double> expertJoint7Y = new List<double>();
    public List<double> expertJoint7Z = new List<double>();
    public List<double> expertJoint8X = new List<double>();
    public List<double> expertJoint8Y = new List<double>();
    public List<double> expertJoint8Z = new List<double>();
    public List<double> expertJoint9X = new List<double>();
    public List<double> expertJoint9Y = new List<double>();
    public List<double> expertJoint9Z = new List<double>();
    public List<double> expertJoint10X = new List<double>();
    public List<double> expertJoint10Y = new List<double>();
    public List<double> expertJoint10Z = new List<double>();
    public List<double> expertJoint11X = new List<double>();
    public List<double> expertJoint11Y = new List<double>();
    public List<double> expertJoint11Z = new List<double>();
    public List<double> expertJoint12X = new List<double>();
    public List<double> expertJoint12Y = new List<double>();
    public List<double> expertJoint12Z = new List<double>();
    public List<double> expertJoint13X = new List<double>();
    public List<double> expertJoint13Y = new List<double>();
    public List<double> expertJoint13Z = new List<double>();
    public List<double> expertJoint14X = new List<double>();
    public List<double> expertJoint14Y = new List<double>();
    public List<double> expertJoint14Z = new List<double>();
    public List<double> expertJoint15X = new List<double>();
    public List<double> expertJoint15Y = new List<double>();
    public List<double> expertJoint15Z = new List<double>();
    public List<double> expertJoint16X = new List<double>();
    public List<double> expertJoint16Y = new List<double>();
    public List<double> expertJoint16Z = new List<double>();
    public List<double> expertJoint17X = new List<double>();
    public List<double> expertJoint17Y = new List<double>();
    public List<double> expertJoint17Z = new List<double>();
    public List<double> expertJoint18X = new List<double>();
    public List<double> expertJoint18Y = new List<double>();
    public List<double> expertJoint18Z = new List<double>();
    public List<double> expertJoint19X = new List<double>();
    public List<double> expertJoint19Y = new List<double>();
    public List<double> expertJoint19Z = new List<double>();

    public List<double> amatureJoint0X = new List<double>();
    public List<double> amatureJoint0Y = new List<double>();
    public List<double> amatureJoint0Z = new List<double>();
    public List<double> amatureJoint1X = new List<double>();
    public List<double> amatureJoint1Y = new List<double>();
    public List<double> amatureJoint1Z = new List<double>();
    public List<double> amatureJoint2X = new List<double>();
    public List<double> amatureJoint2Y = new List<double>();
    public List<double> amatureJoint2Z = new List<double>();
    public List<double> amatureJoint3X = new List<double>();
    public List<double> amatureJoint3Y = new List<double>();
    public List<double> amatureJoint3Z = new List<double>();
    public List<double> amatureJoint4X = new List<double>();
    public List<double> amatureJoint4Y = new List<double>();
    public List<double> amatureJoint4Z = new List<double>();
    public List<double> amatureJoint5X = new List<double>();
    public List<double> amatureJoint5Y = new List<double>();
    public List<double> amatureJoint5Z = new List<double>();
    public List<double> amatureJoint6X = new List<double>();
    public List<double> amatureJoint6Y = new List<double>();
    public List<double> amatureJoint6Z = new List<double>();
    public List<double> amatureJoint7X = new List<double>();
    public List<double> amatureJoint7Y = new List<double>();
    public List<double> amatureJoint7Z = new List<double>();
    public List<double> amatureJoint8X = new List<double>();
    public List<double> amatureJoint8Y = new List<double>();
    public List<double> amatureJoint8Z = new List<double>();
    public List<double> amatureJoint9X = new List<double>();
    public List<double> amatureJoint9Y = new List<double>();
    public List<double> amatureJoint9Z = new List<double>();
    public List<double> amatureJoint10X = new List<double>();
    public List<double> amatureJoint10Y = new List<double>();
    public List<double> amatureJoint10Z = new List<double>();
    public List<double> amatureJoint11X = new List<double>();
    public List<double> amatureJoint11Y = new List<double>();
    public List<double> amatureJoint11Z = new List<double>();
    public List<double> amatureJoint12X = new List<double>();
    public List<double> amatureJoint12Y = new List<double>();
    public List<double> amatureJoint12Z = new List<double>();
    public List<double> amatureJoint13X = new List<double>();
    public List<double> amatureJoint13Y = new List<double>();
    public List<double> amatureJoint13Z = new List<double>();
    public List<double> amatureJoint14X = new List<double>();
    public List<double> amatureJoint14Y = new List<double>();
    public List<double> amatureJoint14Z = new List<double>();
    public List<double> amatureJoint15X = new List<double>();
    public List<double> amatureJoint15Y = new List<double>();
    public List<double> amatureJoint15Z = new List<double>();
    public List<double> amatureJoint16X = new List<double>();
    public List<double> amatureJoint16Y = new List<double>();
    public List<double> amatureJoint16Z = new List<double>();
    public List<double> amatureJoint17X = new List<double>();
    public List<double> amatureJoint17Y = new List<double>();
    public List<double> amatureJoint17Z = new List<double>();
    public List<double> amatureJoint18X = new List<double>();
    public List<double> amatureJoint18Y = new List<double>();
    public List<double> amatureJoint18Z = new List<double>();
    public List<double> amatureJoint19X = new List<double>();
    public List<double> amatureJoint19Y = new List<double>();
    public List<double> amatureJoint19Z = new List<double>();

    public List<double[]> expertArrays = new List<double[]>();
    public List<double[]> amatureArrays = new List<double[]>();

    public void JointProgressionExpert()
    {
        expertMovementHipCenterX = expertJoint0X.ToArray();
        expertMovementHipCenterY = expertJoint0Y.ToArray();
        expertMovementHipCenterZ = expertJoint0Z.ToArray();

        expertMovementSpineX = expertJoint1X.ToArray();   
        expertMovementSpineY = expertJoint1Y.ToArray();   
        expertMovementSpineZ = expertJoint1Z.ToArray();

        expertMovementShoulderCenterX = expertJoint2X.ToArray();
        expertMovementShoulderCenterY = expertJoint2Y.ToArray();
        expertMovementShoulderCenterZ = expertJoint2Z.ToArray();

        expertMovementHeadX = expertJoint3X.ToArray();
        expertMovementHeadY = expertJoint3Y.ToArray();
        expertMovementHeadZ = expertJoint3Z.ToArray();

        expertMovementShoulderLeftX = expertJoint4X.ToArray();
        expertMovementShoulderLeftY = expertJoint4Y.ToArray();
        expertMovementShoulderLeftZ = expertJoint4Z.ToArray();

        expertMovementElbowLeftX = expertJoint5X.ToArray();
        expertMovementElbowLeftY = expertJoint5Y.ToArray();
        expertMovementElbowLeftZ = expertJoint5Z.ToArray();

        expertMovementWristLeftX = expertJoint6X.ToArray();
        expertMovementWristLeftY = expertJoint6Y.ToArray();
        expertMovementWristLeftZ = expertJoint6Z.ToArray();

        expertMovementHandLeftX = expertJoint7X.ToArray();
        expertMovementHandLeftY = expertJoint7Y.ToArray();
        expertMovementHandLeftZ = expertJoint7Z.ToArray();

        expertMovementShoulderRightX = expertJoint8X.ToArray();
        expertMovementShoulderRightY = expertJoint8Y.ToArray();
        expertMovementShoulderRightZ = expertJoint8Z.ToArray();

        expertMovemenElbowRightX = expertJoint9X.ToArray();
        expertMovemenElbowRightY = expertJoint9Y.ToArray();
        expertMovemenElbowRightZ = expertJoint9Z.ToArray();

        expertMovementWristRightX = expertJoint10X.ToArray();
        expertMovementWristRightY = expertJoint10Y.ToArray();
        expertMovementWristRightZ = expertJoint10Z.ToArray();

        expertMovementHandRightX = expertJoint11X.ToArray();
        expertMovementHandRightY = expertJoint11Y.ToArray();
        expertMovementHandRightZ = expertJoint11Z.ToArray();

        expertMovementHipLeftX = expertJoint12X.ToArray();
        expertMovementHipLeftY = expertJoint12Y.ToArray();
        expertMovementHipLeftZ = expertJoint12Z.ToArray();

        expertMovementKneeLeftX = expertJoint13X.ToArray();
        expertMovementKneeLeftY = expertJoint13Y.ToArray();
        expertMovementKneeLeftZ = expertJoint13Z.ToArray();

        expertMovementAnkcleLeftX = expertJoint14X.ToArray();
        expertMovementAnkcleLeftY = expertJoint14Y.ToArray();
        expertMovementAnkcleLeftZ = expertJoint14Z.ToArray();

        expertMovementFootLeftX = expertJoint15X.ToArray();
        expertMovementFootLeftY = expertJoint15Y.ToArray();
        expertMovementFootLeftZ = expertJoint15Z.ToArray();

        expertMovementHipRightX = expertJoint16X.ToArray();
        expertMovementHipRightY = expertJoint16Y.ToArray();
        expertMovementHipRightZ = expertJoint16Z.ToArray();

        expertMovementKneeRightX = expertJoint17X.ToArray();
        expertMovementKneeRightY = expertJoint17Y.ToArray();
        expertMovementKneeRightZ = expertJoint17Z.ToArray();

        expertMovementAnckleRightX = expertJoint18X.ToArray();
        expertMovementAnckleRightY = expertJoint18Y.ToArray();
        expertMovementAnckleRightZ = expertJoint18Z.ToArray();

        expertMovementFootRightX = expertJoint19X.ToArray();
        expertMovementFootRightY = expertJoint19Y.ToArray();
        expertMovementFootRightZ = expertJoint19Z.ToArray();
    }

    public void JointProgressionAmature()
    {
        amatureMovementHipCenterX = amatureJoint0X.ToArray();
        amatureMovementHipCenterY = amatureJoint0Y.ToArray();
        amatureMovementHipCenterZ = amatureJoint0Z.ToArray();

        amatureMovementSpineX = amatureJoint1X.ToArray();
        amatureMovementSpineY = amatureJoint1Y.ToArray();
        amatureMovementSpineZ = amatureJoint1Z.ToArray();

        amatureMovementShoulderCenterX = amatureJoint2X.ToArray();
        amatureMovementShoulderCenterY = amatureJoint2Y.ToArray();
        amatureMovementShoulderCenterZ = amatureJoint2Z.ToArray();

        amatureMovementHeadX = amatureJoint3X.ToArray();
        amatureMovementHeadY = amatureJoint3Y.ToArray();
        amatureMovementHeadZ = amatureJoint3Z.ToArray();

        amatureMovementShoulderLeftX = amatureJoint4X.ToArray();
        amatureMovementShoulderLeftY = amatureJoint4Y.ToArray();
        amatureMovementShoulderLeftZ = amatureJoint4Z.ToArray();

        amatureMovementElbowLeftX = amatureJoint5X.ToArray();
        amatureMovementElbowLeftY = amatureJoint5Y.ToArray();
        amatureMovementElbowLeftZ = amatureJoint5Z.ToArray();

        amatureMovementWristLeftX = amatureJoint6X.ToArray();
        amatureMovementWristLeftY = amatureJoint6Y.ToArray();
        amatureMovementWristLeftZ = amatureJoint6Z.ToArray();

        amatureMovementHandLeftX = amatureJoint7X.ToArray();
        amatureMovementHandLeftY = amatureJoint7Y.ToArray();
        amatureMovementHandLeftZ = amatureJoint7Z.ToArray();

        amatureMovementShoulderRightX = amatureJoint8X.ToArray();
        amatureMovementShoulderRightY = amatureJoint8Y.ToArray();
        amatureMovementShoulderRightZ = amatureJoint8Z.ToArray();

        amatureMovementElbowRightX = amatureJoint9X.ToArray();
        amatureMovementElbowRightY = amatureJoint9Y.ToArray();
        amatureMovementElbowRightZ = amatureJoint9Z.ToArray();

        amatureMovementWristRightX = amatureJoint10X.ToArray();
        amatureMovementWristRightY = amatureJoint10Y.ToArray();
        amatureMovementWristRightZ = amatureJoint10Z.ToArray();

        amatureMovementHandRightX = amatureJoint11X.ToArray();
        amatureMovementHandRightY = amatureJoint11Y.ToArray();
        amatureMovementHandRightZ = amatureJoint11Z.ToArray();

        amatureMovementHipLeftX = amatureJoint12X.ToArray();
        amatureMovementHipLeftY = amatureJoint12Y.ToArray();
        amatureMovementHipLeftZ = amatureJoint12Z.ToArray();

        amatureMovementKneeLeftX = amatureJoint13X.ToArray();
        amatureMovementKneeLeftY = amatureJoint13Y.ToArray();
        amatureMovementKneeLeftZ = amatureJoint13Z.ToArray();

        amatureMovementAnkcleLeftX = amatureJoint14X.ToArray();
        amatureMovementAnkcleLeftY = amatureJoint14Y.ToArray();
        amatureMovementAnkcleLeftZ = amatureJoint14Z.ToArray();

        amatureMovementFootLeftX = amatureJoint15X.ToArray();
        amatureMovementFootLeftY = amatureJoint15Y.ToArray();
        amatureMovementFootLeftZ = amatureJoint15Z.ToArray();

        amatureMovementHipRightX = amatureJoint16X.ToArray();
        amatureMovementHipRightY = amatureJoint16Y.ToArray();
        amatureMovementHipRightZ = amatureJoint16Z.ToArray();

        amatureMovementKneeRightX = amatureJoint17X.ToArray();
        amatureMovementKneeRightY = amatureJoint17Y.ToArray();
        amatureMovementKneeRightZ = amatureJoint17Z.ToArray();

        amatureMovementAnkcleRightX = amatureJoint18X.ToArray();
        amatureMovementAnkcleRightY = amatureJoint18Y.ToArray();
        amatureMovementAnkcleRightZ = amatureJoint18Z.ToArray();

        amatureMovementFootRightX = amatureJoint19X.ToArray();
        amatureMovementFootRightY = amatureJoint19Y.ToArray();
        amatureMovementFootRightZ = amatureJoint19Z.ToArray();
    }

    public void ExpertArrays()
    {
        expertArrays.Add(expertMovementHipCenterX);
        expertArrays.Add(expertMovementHipCenterY);
        expertArrays.Add(expertMovementHipCenterZ);
        expertArrays.Add(expertMovementSpineX);
        expertArrays.Add(expertMovementSpineY);
        expertArrays.Add(expertMovementSpineZ);
        expertArrays.Add(expertMovementShoulderCenterX);
        expertArrays.Add(expertMovementShoulderCenterY);
        expertArrays.Add(expertMovementShoulderCenterZ);
        expertArrays.Add(expertMovementHeadX);
        expertArrays.Add(expertMovementHeadY);
        expertArrays.Add(expertMovementHeadZ);
        expertArrays.Add(expertMovementShoulderLeftX);
        expertArrays.Add(expertMovementShoulderLeftY);
        expertArrays.Add(expertMovementShoulderLeftZ);
        expertArrays.Add(expertMovementElbowLeftX);
        expertArrays.Add(expertMovementElbowLeftY);
        expertArrays.Add(expertMovementElbowLeftZ);
        expertArrays.Add(expertMovementWristLeftX);
        expertArrays.Add(expertMovementWristLeftY);
        expertArrays.Add(expertMovementWristLeftZ);
        expertArrays.Add(expertMovementHandLeftX);
        expertArrays.Add(expertMovementHandLeftY);
        expertArrays.Add(expertMovementHandLeftZ);
        expertArrays.Add(expertMovementShoulderRightX);
        expertArrays.Add(expertMovementShoulderRightY);
        expertArrays.Add(expertMovementShoulderRightZ);
        expertArrays.Add(expertMovemenElbowRightX);
        expertArrays.Add(expertMovemenElbowRightY);
        expertArrays.Add(expertMovemenElbowRightZ);
        expertArrays.Add(expertMovementWristRightX);
        expertArrays.Add(expertMovementWristRightY);
        expertArrays.Add(expertMovementWristRightZ);
        expertArrays.Add(expertMovementHandRightX);
        expertArrays.Add(expertMovementHandRightY);
        expertArrays.Add(expertMovementHandRightZ);
        expertArrays.Add(expertMovementHipLeftX);
        expertArrays.Add(expertMovementHipLeftY);
        expertArrays.Add(expertMovementHipLeftZ);
        expertArrays.Add(expertMovementKneeLeftX);
        expertArrays.Add(expertMovementKneeLeftY);
        expertArrays.Add(expertMovementKneeLeftZ);
        expertArrays.Add(expertMovementAnkcleLeftX);
        expertArrays.Add(expertMovementAnkcleLeftY);
        expertArrays.Add(expertMovementAnkcleLeftZ);
        expertArrays.Add(expertMovementFootLeftX);
        expertArrays.Add(expertMovementFootLeftY);
        expertArrays.Add(expertMovementFootLeftZ);
        expertArrays.Add(expertMovementHipRightX);
        expertArrays.Add(expertMovementHipRightY);
        expertArrays.Add(expertMovementHipRightZ);
        expertArrays.Add(expertMovementKneeRightX);
        expertArrays.Add(expertMovementKneeRightY);
        expertArrays.Add(expertMovementKneeRightZ);
        expertArrays.Add(expertMovementAnckleRightX);
        expertArrays.Add(expertMovementAnckleRightY);
        expertArrays.Add(expertMovementAnckleRightZ);
        expertArrays.Add(expertMovementFootRightX);
        expertArrays.Add(expertMovementFootRightY);
        expertArrays.Add(expertMovementFootRightZ);
    }

    public void AmatureArrays()
    {
        amatureArrays.Add(amatureMovementHipCenterX);
        amatureArrays.Add(amatureMovementHipCenterY);
        amatureArrays.Add(amatureMovementHipCenterZ);
        amatureArrays.Add(amatureMovementSpineX);
        amatureArrays.Add(amatureMovementSpineY);
        amatureArrays.Add(amatureMovementSpineZ);
        amatureArrays.Add(amatureMovementShoulderCenterX);
        amatureArrays.Add(amatureMovementShoulderCenterY);
        amatureArrays.Add(amatureMovementShoulderCenterZ);
        amatureArrays.Add(amatureMovementHeadX);
        amatureArrays.Add(amatureMovementHeadY);
        amatureArrays.Add(amatureMovementHeadZ);
        amatureArrays.Add(amatureMovementShoulderLeftX);
        amatureArrays.Add(amatureMovementShoulderLeftY);
        amatureArrays.Add(amatureMovementShoulderLeftZ);
        amatureArrays.Add(amatureMovementElbowLeftX);
        amatureArrays.Add(amatureMovementElbowLeftY);
        amatureArrays.Add(amatureMovementElbowLeftZ);
        amatureArrays.Add(amatureMovementWristLeftX);
        amatureArrays.Add(amatureMovementWristLeftY);
        amatureArrays.Add(amatureMovementWristLeftZ);
        amatureArrays.Add(amatureMovementHandLeftX);
        amatureArrays.Add(amatureMovementHandLeftY);
        amatureArrays.Add(amatureMovementHandLeftZ);
        amatureArrays.Add(amatureMovementShoulderRightX);
        amatureArrays.Add(amatureMovementShoulderRightY);
        amatureArrays.Add(amatureMovementShoulderRightZ);
        amatureArrays.Add(amatureMovementElbowRightX);
        amatureArrays.Add(amatureMovementElbowRightY);
        amatureArrays.Add(amatureMovementElbowRightZ);
        amatureArrays.Add(amatureMovementWristRightX);
        amatureArrays.Add(amatureMovementWristRightY);
        amatureArrays.Add(amatureMovementWristRightZ);
        amatureArrays.Add(amatureMovementHandRightX);
        amatureArrays.Add(amatureMovementHandRightY);
        amatureArrays.Add(amatureMovementHandRightZ);
        amatureArrays.Add(amatureMovementHipLeftX);
        amatureArrays.Add(amatureMovementHipLeftY);
        amatureArrays.Add(amatureMovementHipLeftZ);
        amatureArrays.Add(amatureMovementKneeLeftX);
        amatureArrays.Add(amatureMovementKneeLeftY);
        amatureArrays.Add(amatureMovementKneeLeftZ);
        amatureArrays.Add(amatureMovementAnkcleLeftX);
        amatureArrays.Add(amatureMovementAnkcleLeftY);
        amatureArrays.Add(amatureMovementAnkcleLeftZ);
        amatureArrays.Add(amatureMovementFootLeftX);
        amatureArrays.Add(amatureMovementFootLeftY);
        amatureArrays.Add(amatureMovementFootLeftZ);
        amatureArrays.Add(amatureMovementHipRightX);
        amatureArrays.Add(amatureMovementHipRightY);
        amatureArrays.Add(amatureMovementHipRightZ);
        amatureArrays.Add(amatureMovementKneeRightX);
        amatureArrays.Add(amatureMovementKneeRightY);
        amatureArrays.Add(amatureMovementKneeRightZ);
        amatureArrays.Add(amatureMovementAnkcleRightX);
        amatureArrays.Add(amatureMovementAnkcleRightY);
        amatureArrays.Add(amatureMovementAnkcleRightZ);
        amatureArrays.Add(amatureMovementFootRightX);
        amatureArrays.Add(amatureMovementFootRightY);
        amatureArrays.Add(amatureMovementFootRightZ);
    }
}
