using UnityEngine;

namespace Construction3D.Sand
{
    public class SandController : MonoBehaviour
    {
        public event System.Action<Vector3> onSandDestroy;
        private bool allowDecreaseCounter;
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Digger"))
            {
                onSandDestroy?.Invoke(transform.position);
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

