using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DTW;
public class NewBehaviourScript : MonoBehaviour
{
    double[] x = new double[] { 1, 5, 6, 8};
    double[] y = new double[] { 1, 5, 15, 8};
   
    void Start()
    {
        SimpleDTW simpleDTW = new SimpleDTW(x, y);
        simpleDTW.computeDTW();
        Debug.Log("Test Sum is: " + simpleDTW.getSum());
    }
}
