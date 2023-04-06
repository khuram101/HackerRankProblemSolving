using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberLineJumps : MonoBehaviour
{
    [SerializeField] private int x1, v1, x2, v2;
    void Start()
    {
        Debug.Log(Kangaroo(x1, v1, x2, v2));
    }

    public string Kangaroo(int x1, int v1, int x2, int v2)
    {
        if (v1 < v2 && v1 < v2)
            return "NO";

        if (v1 != v2 && (x2 - x1) % (v1 - v2) == 0) return "YES";
        else
            return "NO";

    }

}
