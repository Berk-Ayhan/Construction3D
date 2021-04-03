using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiggerClamper : MonoBehaviour
{
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -2.5f, 2.5f), Mathf.Clamp(transform.position.y, -3f, 5f), transform.position.z);
    }
}
