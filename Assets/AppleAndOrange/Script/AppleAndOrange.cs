using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleAndOrange : MonoBehaviour
{
    [SerializeField] private InputData inputData;
    // Start is called before the first frame update
    void Start()
    {

    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            countApplesAndOranges(inputData.HouseInitialPoint, inputData.HouseEndPoint, inputData.AppleTreePosition, 
                inputData.OrangeTreePosition, inputData.ApplesFallPositions, inputData.OrangeFallPositions);
        }
    }

    /*s: integer, starting point of Sam's house location.
    t: integer, ending location of Sam's house location.
    a: integer, location of the Apple tree.
    b: integer, location of the Orange tree.
    apples: integer array, distances at which each apple falls from the tree.
    oranges: integer array, distances at which each orange falls from the tree.*/
    public void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
    {

        int fellOnCounter = 0;
        for (int i = 0; i < apples.Count; i++)
        {
            var dist = a + apples[i];
            if (dist >= s && dist <= t) fellOnCounter++;
        }
        Debug.Log(fellOnCounter);
        fellOnCounter = 0;
        for (int i = 0; i < oranges.Count; i++)
        {
            var dist = b + oranges[i];
            if (dist >= s && dist <= t) fellOnCounter++;
        }
        Debug.Log(fellOnCounter);


    }

    [System.Serializable]
    public class InputData
    {
        public int HouseInitialPoint;
        public int HouseEndPoint;
        public int AppleTreePosition;
        public int OrangeTreePosition;
        public List<int> ApplesFallPositions;
        public List<int> OrangeFallPositions;
    }
}
