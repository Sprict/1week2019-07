using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoseSpot : MonoBehaviour
{
    int numSpots = 9;
    int[] array;
    // Start is called before the first frame update
    void Start()
    {
        array = new int[4];
        randomselect4(array, numSpots);
    }

    void randomselect4(int[] a, int num)
    {
        foreach (int e in a)
        {
            int rand = Random.Range(1, numSpots + 1);
            bool isequal = false;
            foreach (int j in a)
            {
                if (rand == j)
                {
                    isequal = true;
                    break;
                }
            }
            if (isequal)
            {
                continue;
            }
            a[e] = rand;
        }

        foreach(int i in a)
        {
            Debug.Log(a[i]);
        }
    }

}
