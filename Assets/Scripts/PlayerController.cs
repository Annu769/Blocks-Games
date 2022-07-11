using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D Rigidbody;
    public GameObject GameWonPanel;
    public float speed;
    private bool isGameWon = false;
   
    void Update()
    {
      if(isGameWon == true)
      {
        return;
      }
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
         GameWonPanel.SetActive(true);
         isGameWon = true;
    }

}
