using UnityEngine;

public class PlayerMouvement : MonoBehaviour 

{
    public Rigidbody rb;

    public float forwadForce = 2000f;
    public float sidewayForce = 500f;

   
    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwadForce * Time.deltaTime);

        if(Input.GetKey("d"))
        {
            rb.AddForce(sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("q"))
        {
            rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();  
        }
    }
}
