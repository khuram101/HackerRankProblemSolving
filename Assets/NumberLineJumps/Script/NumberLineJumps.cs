using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//speed = distance/jumps
//distance= speed*jumps
//after "j" jumps/seconds both kangros reach at same position
//distace = v1*j;
//total distance = (v1*j)+x1(starting position)
// both kangroos position must be equal if return "True"
// x1+(v1*j)=x2+(v2*j)
//x2-x1= (v1-v2)*j
// j= (x2-x1)/v1-v2) after j jump they meet at point
//if v1 is greater than v2 and (x2 - x1) % (v1 - v2) == 0 they they will meet otherwise not 
public class NumberLineJumps : MonoBehaviour
{
    [SerializeField] private int x1, v1, x2, v2;
    void Start()
    {
        Debug.Log(Kangaroo(x1, v1, x2, v2));
    }

    public string Kangaroo(int x1, int v1, int x2, int v2)
    {

        if (v1 > v2 && (x2 - x1) % (v1 - v2) == 0) return "YES";
        else
            return "NO";

    }

}
