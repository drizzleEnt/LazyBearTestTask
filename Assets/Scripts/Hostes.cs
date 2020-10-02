using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;

public class Hostes : MonoBehaviour
{
    public int[] _randNums = new int[10];

    public void GenerateNumber()
    {
        System.Random rand = new System.Random();
        
        for (int i = 0; i < _randNums.Length; i++)
        {
            bool contains;
            int next;
            do
            {
                next = rand.Next(_randNums.Length);
                contains = false;
                for (int j = 0; j < i; j++)
                {
                    int n = _randNums[j];
                    if (n == next)
                    {
                        contains = true;
                        break;
                    }
                }
            } while (contains);
            _randNums[i] = next;

        }
   
    }
}
