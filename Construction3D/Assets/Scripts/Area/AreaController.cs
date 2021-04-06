using UnityEngine;
using TMPro;
namespace Construction3D.Area
{
    public class AreaController : MonoBehaviour
    {
        public static int sandCounter = 0;
        [SerializeField] private TextMeshProUGUI text;
        private void Awake()
        {
            text = FindObjectOfType<TextMeshProUGUI>().GetComponent<TextMeshProUGUI>();
        }
        private bool isAreaClear
        {
            get { return sandCounter == 0; }
        }
        private void Update()
        {
            if (isAreaClear)
            {
                text.text = "Level Completed";
                Destroy(gameObject);
            }
        }
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Sand"))
            {
                sandCounter++;
            }
        }
    }
}

