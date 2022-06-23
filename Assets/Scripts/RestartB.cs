using UnityEngine.SceneManagement;
using UnityEngine;

public class RestartB : MonoBehaviour
{
   public void restart()
    {
        SceneManager.LoadScene(1);
    }
}
