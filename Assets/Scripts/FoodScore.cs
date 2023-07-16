using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FoodScore : MonoBehaviour

{
    public Text scoreText;
    public static int score;
    public Manager gameManager;

    void Update(){
        if (gameManager.gameHasEnded == false)
        {
            scoreText.GetComponent<Text>().text = score.ToString();
        }
        else if (gameManager.completeLevelUI.activeSelf == true)
        {
            scoreText.GetComponent<Text>().enabled = false;
        }
        else
        {
            scoreText.GetComponent<Text>().text = "You Lose. Lol.";
           
        }
    
}

    void OnCollisionEnter (Collision collisionInfo) 
    {
        if (collisionInfo.collider.tag == "Food")
        {
            score++;
            
            
        }
    }
}

