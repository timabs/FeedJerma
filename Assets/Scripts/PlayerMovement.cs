using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // rigid body component called rb
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sideForce = 500f;
    public float fallBoundary = -1f;

    // Start is called before the first frame update
    

    // We made this "Fixed"Update b/c we're changing physics
    void FixedUpdate()
    {   
        //add a forward force
        rb.AddForce (0, 0, forwardForce * Time.deltaTime);
        rb.constraints = RigidbodyConstraints.FreezeRotation;
       

        if (Input.GetKey("d"))
        {
            rb.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a")) 
        {
            rb.AddForce(-1 * sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < fallBoundary)
        {
            FindObjectOfType<Manager>().EndGame();
        }

        
}
}
