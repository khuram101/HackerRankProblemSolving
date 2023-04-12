using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubArrayDivision : MonoBehaviour
{
    [SerializeField] List<int> firststInput = new();
    [SerializeField] List<int> secondInput = new();
    void Start()
    {

    }


    void GenerateFactor()
    {

        var x = firststInput[0];
        for (int i = x; i < secondInput[0]; i++)
        {
            if (i % 2 == 0)
            {
                Debug.Log("diviser: " + i);
            }
        }


        Debug.Log("" + x);


    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.G)) GenerateFactor();
    }
}
