using UnityEngine.SceneManagement;
using UnityEngine;

public class StartB : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
