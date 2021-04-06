using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject panel;

    private void LevelCompleted()
    {
        panel.SetActive(true);
    }
    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
