using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Week2_1 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("(2,2) to (5,6)" + GetDistance(2,2,5,6));        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private float GetDistance(int x1, int y1, int x2, int y2)
    {
        float width = x2 - x1;
        float height = y2 - y1;

        return Mathf.Sqrt(width*width + height*height);
    }
}
