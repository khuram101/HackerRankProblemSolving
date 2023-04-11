using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakingTheRecord : MonoBehaviour
{
    [SerializeField] private List<int> inputScores = new();
    void Start()
    {
        List<int> result = BreakingRecords(inputScores);
        Debug.Log("Result: " + result[0] + " " + result[1]);
    }

    public List<int> BreakingRecords(List<int> scores)
    {
        var previouseMinScore = scores[0];
        var currentMaxScore = scores[0];

        var worstRecordTime = 0;
        var bestRecordTimes = 0;
        List<int> returnRecord = new();

        for (int i = 0; i < scores.Count; i++)
        {
            if (scores[i] < previouseMinScore)
            {
                worstRecordTime++;
                previouseMinScore = scores[i];
            }


            if (scores[i] > currentMaxScore)
            {
                bestRecordTimes++;
                currentMaxScore = scores[i];
            }


        }
        returnRecord.Add(bestRecordTimes);
        returnRecord.Add(worstRecordTime);

        return returnRecord;
    }
}
