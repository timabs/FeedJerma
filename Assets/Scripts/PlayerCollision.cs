using UnityEngine;

public class PlayerCollision : MonoBehaviour


{
    public PlayerMovement movement;
    public float collisionForce = 500000f;
    public FoodScore foodScore;
    

    

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.rb.constraints = RigidbodyConstraints.None;
            movement.rb.AddForce(0, 0, collisionForce * Time.deltaTime);          
            GetComponent<PlayerMovement>().enabled = false;
            FindObjectOfType<Manager>().EndGame();
            FoodScore.score = 0;
            
        }
       
      
    }
}
