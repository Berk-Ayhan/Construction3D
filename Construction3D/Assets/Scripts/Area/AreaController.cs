using UnityEngine;

public class AreaController : MonoBehaviour
{
    public static int sandCounter = 0;
    private bool isAreaClear
    {
        get { return sandCounter == 0; }
    }
    private void Update()
    {
        if (isAreaClear)
        {
            print("Ba�ar�l�");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Sand"))
        {
            sandCounter++;
            print(sandCounter);
        }
    }
}
