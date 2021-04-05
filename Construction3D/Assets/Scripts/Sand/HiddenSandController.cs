using UnityEngine;

namespace Construction3D.Sand
{
    public class HiddenSandController : MonoBehaviour
    {
        public GameObject sandPrefab;
        private SandController sandController;
        private void Awake()
        {
            sandController = FindObjectOfType<SandController>();
        }
        private void OnEnable()
        {
            sandController.onSandDestroy += HiddenSandGenerator;
        }
        private void HiddenSandGenerator(Vector3 coordinates)
        {
            print(coordinates);
            coordinates += new Vector3(0, 7, 0);
            var generatedSand = Instantiate(sandPrefab, coordinates, Quaternion.identity);
            generatedSand.transform.SetParent(transform);
        }
        private void OnDestroy()
        {
            sandController.onSandDestroy -= HiddenSandGenerator;
        }
    }
}