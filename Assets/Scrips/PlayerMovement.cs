using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float forwardF = 2000f;
    public float rightForce = 500f;
    public float leftForce = 500f;
    public float jumpForce = 500f;

    // Update is called once per frame
    //FixedUpdate is better while dealing with physics
    void FixedUpdate()
    {
        //Add a forward force
        rb.AddForce(0, 0, forwardF * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(rightForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-leftForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, forwardF * Time.deltaTime);
        }
        if (Input.GetKey("x"))
        {
            rb.AddForce(0, 0, -forwardF * Time.deltaTime);
        }

        if(Input.GetKey("space"))
        {
            rb.AddForce(0, jumpForce * Time.deltaTime, 0);
        }

        if (Input.GetKey("s"))
        {
            rb.AddForce(0, -jumpForce * Time.deltaTime, 0);
        }

        if (rb.position.y < -1.5f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
