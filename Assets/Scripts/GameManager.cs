using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject endUI;
    float restartTime = 1f;
    bool gameEnded = false;
    public void endGame()
    {
        if(gameEnded == false)
        {
            gameEnded = true;          
            Invoke("Restart", restartTime);
        }
        
    }

    public void levelComplete()
    {
        Debug.Log("level won");
        endUI.SetActive(true);
    }
    
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name) ;
    }
}
