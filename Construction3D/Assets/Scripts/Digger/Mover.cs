using System.Collections;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float speedX = 150f;
    [SerializeField] private float speedY = 6f;
    public void MoveDown()
    {
        transform.Translate(Vector3.down * Time.fixedDeltaTime
            * speedY);
    }
    public void MoveUp()
    {
        transform.Translate(Vector3.up * Time.fixedDeltaTime
            * speedY);
    }
    public void MoveHorizontal(Rigidbody rb, Vector3 directionX)
    {
        rb.velocity += directionX * speedX * Time.fixedDeltaTime;
    }
    public void StopHorizontal(Rigidbody rb)
    {
        rb.velocity = new Vector3(0f, rb.velocity.y, rb.velocity.z);
    }
}
