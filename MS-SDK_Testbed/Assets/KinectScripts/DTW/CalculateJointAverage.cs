using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculateJointAverage
{
    public List<double> dtwResults = new List<double>();

    public (double, double, double, double, double, double, double, double, double, double, double, double, double, double, double, double, double, double, double, double)CalculateAverage()
    {
        double HipCenterAvg = (dtwResults[0] + dtwResults[1] + dtwResults[2]) / 3;
        double SpineAvg = (dtwResults[3] + dtwResults[4] + dtwResults[5]) / 3;
        double ShoulderCenterAvg = (dtwResults[6] + dtwResults[7] + dtwResults[8]) / 3;
        double HeadAvg = (dtwResults[9] + dtwResults[10] + dtwResults[11]) / 3;
        double ShoulderLeftAvg = (dtwResults[12] + dtwResults[13] + dtwResults[14]) / 3;
        double ElbowLeftAvg = (dtwResults[15] + dtwResults[16] + dtwResults[17]) / 3;
        double WristLeftAvg = (dtwResults[18] + dtwResults[19] + dtwResults[20]) / 3;
        double HandLeftAvg = (dtwResults[21] + dtwResults[22] + dtwResults[23]) / 3;
        double ShoulderRightAvg = (dtwResults[24] + dtwResults[25] + dtwResults[26]) / 3;
        double ElbowRightAvg = (dtwResults[27] + dtwResults[28] + dtwResults[29]) / 3;
        double WristRightAvg = (dtwResults[30] + dtwResults[31] + dtwResults[32]) / 3;
        double HandRightAvg = (dtwResults[33] + dtwResults[34] + dtwResults[35]) / 3;
        double HipLeftAvg = (dtwResults[36] + dtwResults[37] + dtwResults[38]) / 3;
        double KneeLeftAvg = (dtwResults[39] + dtwResults[40] + dtwResults[41]) / 3;
        double AnckleLeftAvg = (dtwResults[42] + dtwResults[43] + dtwResults[44]) / 3;
        double FootLeftAvg = (dtwResults[45] + dtwResults[46] + dtwResults[47]) / 3;
        double HipRightAvg = (dtwResults[48] + dtwResults[49] + dtwResults[50]) / 3;
        double KneeRightAvg = (dtwResults[51] + dtwResults[52] + dtwResults[53]) / 3;
        double AnckleRightAvg = (dtwResults[54] + dtwResults[55] + dtwResults[56]) / 3;
        double FootRightAvg = (dtwResults[57] + dtwResults[58] + dtwResults[59]) / 3;

        return (HipCenterAvg, SpineAvg, ShoulderCenterAvg, HeadAvg, ShoulderLeftAvg, ElbowLeftAvg, WristLeftAvg, HandLeftAvg, ShoulderRightAvg, ElbowRightAvg, WristRightAvg, HandRightAvg, HipLeftAvg, KneeLeftAvg, AnckleLeftAvg, FootLeftAvg, HipRightAvg, KneeRightAvg, AnckleRightAvg, FootRightAvg);
    }
}
