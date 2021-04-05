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
                Destroy(gameObject);
            }
        }
        private void OnTriggerStay(Collider other)
        {
            if (other.gameObject.CompareTag("Area"))
            {
                allowDecreaseCounter = true;
            }
        }
        private void OnDestroy()
        {
            if (allowDecreaseCounter)
            {
                AreaController.sandCounter--;
            }
        }
    }
}

