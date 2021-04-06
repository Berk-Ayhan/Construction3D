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
                DecreaseCounter();
                Destroy(gameObject);
            }
            if (other.gameObject.CompareTag("Area"))
            {
                allowDecreaseCounter = true;
            }
        }
        private void DecreaseCounter()
        {
            if (allowDecreaseCounter)
            {
                AreaController.sandCounter--;
            }
        }
    }
}

