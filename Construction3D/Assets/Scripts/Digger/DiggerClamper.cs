using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiggerClamper : MonoBehaviour
{
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -1.75f, 1.75f), Mathf.Clamp(transform.position.y, -1f, 4f), transform.position.z);
    }
}
