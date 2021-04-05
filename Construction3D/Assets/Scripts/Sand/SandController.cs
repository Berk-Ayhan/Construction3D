using System.Collections;
using System.Collections.Generic;
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
                gameObject.SetActive(false);
            }
        }
        private void OnTriggerStay(Collider other)
        {
            if (other.gameObject.CompareTag("Area"))
            {
                allowDecreaseCounter = true;
            }
        }
        private void OnDisable()
        {
            if (allowDecreaseCounter)
            {
                AreaController.sandCounter--;
            }
        }
    }
}

