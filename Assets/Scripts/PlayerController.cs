using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D Rigidbody;
    public GameObject GameWonPanel;
    public GameObject GameLostPanel;
    public float speed;
    private bool isGameOver = false;
   
    void Update()
    {
      if(isGameOver == true)
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
         isGameOver = true;

          if(other.tag == "Enemy")
         Debug.Log("Level Lost!!!");
         GameWonPanel.SetActive(true);
        isGameOver = true;
    }

    public void RestartGame()
    {
      SceneManager.LoadScene(0);
      Debug.Log("Button Cliked ");
    }

    public void QuitGame()
    {
       Application.Quit();
      Debug.Log("QUIT");
     
    }

}
