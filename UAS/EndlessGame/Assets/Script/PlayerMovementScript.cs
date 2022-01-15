using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerMovementScript : MonoBehaviour
{
    Rigidbody2D movement;
    public float ms;
    public float jumpForce;
    int Score = 0;
    public Text ScoreCounter;  

    // Start is called before the first frame update
    void Start()
    {
        movement = GetComponent<Rigidbody2D>();    
    }

    // Update is called once per frame
    void Update()
    {
        float move = Input.GetAxisRaw("Horizontal");
        movement.velocity = new Vector2(move * ms, movement.velocity.y);

        if (Input.GetKeyUp(KeyCode.Space))
        {
             movement.velocity = Vector2.up * jumpForce;
        }
    }

    void reset(){
        SceneManager.LoadScene("gameover");
    }

    void OnCollisionEnter2D(Collision2D coll){
        if(coll.gameObject.tag == "mycoin"){
            Score++;
            ScoreCounter.text = "Score : " +Score.ToString();
            Destroy(coll.gameObject);
        }

        if(coll.gameObject.tag == "ranjau"){
            reset();    
        }

        if(coll.gameObject.tag == "finish"){
            SceneManager.LoadScene("finish");
        }

        if(coll.gameObject.tag == "enemy"){
            reset(); 
        }
    }

}
