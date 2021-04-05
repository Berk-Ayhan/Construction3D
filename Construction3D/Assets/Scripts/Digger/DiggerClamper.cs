using UnityEngine;

namespace Construction3D.Digger
{
    public class DiggerClamper : MonoBehaviour
    {
        //Limits the digger's movement area
        void Update()
        {
            transform.position = new Vector3(Mathf.Clamp(transform.position.x, -1.5f, 1.5f), Mathf.Clamp(transform.position.y, -1f, 4f), transform.position.z);
        }
    }
}
