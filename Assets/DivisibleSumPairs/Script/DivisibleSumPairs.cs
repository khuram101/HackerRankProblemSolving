using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DivisibleSumPairs : MonoBehaviour
{
    [SerializeField] private int n;
    [SerializeField] private int k;
    [SerializeField] List<int> values= new List<int>();
    void Start()
    {
        Debug.Log(divisibleSumPairs(n,k, values));
    }

    public int divisibleSumPairs(int n, int k, List<int> ar)
    {
        var counter = 0;
        for (int i = 0; i < n - 1; i++)
        {

            for (int j = i + 1; j < n; j++)
            {

                if ((ar[i] + ar[j]) % k == 0)
                    counter++;

            }


        }

        return counter;
    }

   
}
