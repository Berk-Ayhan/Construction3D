using Construction3D.Area;
using UnityEngine;

namespace Construction3D.Sand
{
    public class SandController : MonoBehaviour
    {
        private bool allowDecreaseCounter;
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Digger"))
            {
                DecreaseSandCounter();
                gameObject.SetActive(false);
                transform.position = new Vector3(transform.position.x, transform.position.y + 7, transform.position.z);
                gameObject.SetActive(true);
                //Destroy(gameObject);
            }
            if (other.gameObject.CompareTag("Area"))
            {
                allowDecreaseCounter = true;
            }
        }
        private void DecreaseSandCounter()
        {
            if (allowDecreaseCounter)
            {
                AreaController.sandCounter--;
            }
        }
    }
}

