using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D Rigidbody;
    public float speed;
   
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        if(Input.GetAxis("Horizontal") > 0 )
        {
            Rigidbody.velocity = new Vector2(speed, 0f);
        }
         else if(Input.GetAxis("Horizontal") < 0 )
        {
          Rigidbody.velocity = new Vector2(-speed, 0f);
        }
          else if(Input.GetAxis("Vertical") > 0 )
        {
            Rigidbody.velocity = new Vector2(0f , speed);
        }
          else if(Input.GetAxis("Vertical") < 0 )
        {
           Rigidbody.velocity = new Vector2(0f , -speed);
        }
        else if(Input.GetAxis("Vertical") == 0 && Input.GetAxis("Horizontal") == 0)
        {
            Rigidbody.velocity = new Vector2(0f , 0f);
        }
    }

     void OnTriggerEnter2D(Collider2D other)
        
    {
        if(other.tag == "Door")
         Debug.Log("Level Complete!!!");
    }

}
