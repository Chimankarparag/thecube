using UnityEngine;

public class Playermovement : MonoBehaviour
{
    public Rigidbody RB;

   
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    

    void Start()
    {
        RB.useGravity = true;
        
    }



    void FixedUpdate()
    {
        RB.AddForce(0, 0, 10* Time.deltaTime);

        if (Input.GetKey("d"))
        {
            RB.AddForce(sidewaysForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            RB.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("w"))
        {
            RB.AddForce(0, 0, forwardForce * Time.deltaTime, ForceMode.VelocityChange);
        }
        if (Input.GetKey("s"))
        {
            RB.AddForce(0, 0, -forwardForce * Time.deltaTime, ForceMode.VelocityChange);
        }
        if(RB.position.y < -1f)
        {
            FindObjectOfType<Gamemanager>().Endgame();
        }
       

    }
}
