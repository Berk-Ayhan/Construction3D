using UnityEngine;

namespace Construction3D.Switch
{
    public class Rotater : MonoBehaviour
    {
        public Transform pivotPoint;
        public void RotateLeft()
        {
            if (transform.eulerAngles.z < 30 || transform.eulerAngles.z > 328)
            {
                transform.RotateAround(pivotPoint.position, Vector3.forward, 40 * Time.fixedDeltaTime);
            }
        }
        public void RotateRight()
        {
            if (transform.eulerAngles.z > 330 || transform.eulerAngles.z > 360 || transform.eulerAngles.z < 32)
            {
                transform.RotateAround(pivotPoint.position, Vector3.back, 40 * Time.fixedDeltaTime);
            }
        }
        void FixedUpdate()
        {
            if ((Input.GetKey(KeyCode.A)))
            {
                RotateLeft();
            }
            else if ((Input.GetKey(KeyCode.D)))
            {
                RotateRight();
            }
            else
            {

            }
        }
    }
}

