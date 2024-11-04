using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bubble : MonoBehaviour
     
{
    int[] numberArray = { 5, 3, 8, 4, 2 };

    void Start()
    {
        Debug.Log("Original Array: " = ArrayToString(numberArray));
    }

   
   
    void ArrayToString(int[] array)
    {
        return string.Join(",", array);
    }

    // Update is called once per frame
    
}
