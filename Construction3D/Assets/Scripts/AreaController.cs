using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaController : MonoBehaviour
{
    public static int sandCounter = 0;
    private bool isAreaClear
    {
        get { return sandCounter == 0; }
    }
    private void Update()
    {
        if (isAreaClear)
        {
            //Level Completed
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Sand"))
        {
            sandCounter++;
        }
    }
}
