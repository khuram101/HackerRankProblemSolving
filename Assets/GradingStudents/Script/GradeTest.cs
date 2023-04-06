using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GradeTest : MonoBehaviour
{
    [SerializeField] private List<int> grades= new List<int>() { 73, 67, 38, 33 };
    void Start()
    {
        var grd = GradingStudents(grades);
        foreach (var gd in grd)
        {
            Debug.Log("Updated Grade:" + gd);
        }
    }

    public List<int> GradingStudents(List<int> grades)
    {
        for (int i = 0; i < grades.Count; i++)
        {
            var currentGrade = grades[i];
            var nextMultiple = ((currentGrade / 5) + 1) * 5;
            var diff = nextMultiple - currentGrade;

            if (diff < 3 && currentGrade >= 38)
            {
                currentGrade += diff;
                grades[i] = currentGrade;
            }
        }

        return grades;
    }

}
