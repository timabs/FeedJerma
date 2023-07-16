using UnityEngine;
using UnityEngine.UI;
using System;
using static Manager;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    public Manager endGame;

    // Update is called once per frame
    void Update()
    {
        if (endGame.gameHasEnded == false)
        {
            scoreText.text = (player.position.z.ToString("0"));
        }
        else
        {
            scoreText.text = "You Lose. Lol.";
           
        }
        
         
         
    }
}
