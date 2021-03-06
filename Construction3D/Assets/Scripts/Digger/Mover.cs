using UnityEngine;

namespace Construction3D.Digger
{
    public class Mover : MonoBehaviour
    {
        [SerializeField] private float speedX = 30f;
        [SerializeField] private float speedY = 2f;
        public void MoveDown(Rigidbody _rb)
        {
            transform.Translate(Vector3.down * Time.fixedDeltaTime
                * speedY);
            StopHorizontal(_rb);
        }
        public void MoveUp(Rigidbody _rb)
        {
            transform.Translate(Vector3.up * Time.fixedDeltaTime
                * speedY);
            StopHorizontal(_rb);
        }
        public void MoveHorizontal(Rigidbody rb, Vector3 directionX)
        {
            rb.velocity = directionX * speedX * Time.fixedDeltaTime;
        }
        public void StopHorizontal(Rigidbody rb)
        {
            rb.velocity = new Vector3(0f, rb.velocity.y, rb.velocity.z);
        }
    }
}
