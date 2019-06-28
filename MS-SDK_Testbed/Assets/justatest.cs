using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class justatest : MonoBehaviour
{
    public bool isLoading = true;

    private void Update()
    {
        if (isLoading)
        {
            Test();
        }
    }
    void Test()
    {
        for (int i = 0; i < 10; i++)
        {
            Debug.Log(i);
        }

        isLoading = false;
    }
}
