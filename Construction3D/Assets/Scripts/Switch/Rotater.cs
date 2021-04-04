using UnityEngine;

namespace Construction3D.Switch
{
    public class Rotater : MonoBehaviour
    {
        public Transform pivotPoint;
        //public void RotateLeft()
        //{
        //   
        //}
        //public void RotateRight()
        //{
        //    
        //}
        void FixedUpdate()
        {
            if ((Input.GetKey(KeyCode.A)))
            {
                if (transform.eulerAngles.z < 31 || transform.eulerAngles.z > 331)
                {
                    transform.RotateAround(pivotPoint.position, Vector3.forward, 40 * Time.fixedDeltaTime);
                }
            }
            else if ((Input.GetKey(KeyCode.D)))
            {
                if (transform.eulerAngles.z > 330 || transform.eulerAngles.z < 360)
                {
                    transform.RotateAround(pivotPoint.position, Vector3.back, 40 * Time.fixedDeltaTime);
                }
            }
            //else
            //{
            //    GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            //}
        }
    }
}

