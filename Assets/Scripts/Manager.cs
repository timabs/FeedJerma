using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    public bool gameHasEnded = false;
    private float restartDelay = 1.5f;
    private Score endScore;
    public GameObject completeLevelUI;

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);

    }
    

    public void EndGame()
    {

        if (gameHasEnded == false)
        {
            gameHasEnded = true;

            // Restart game
            Invoke(nameof(Restart), restartDelay);

        }
        
        
    }
    void Restart()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    
    
}
