using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
   [SerializeField]  private float initialVelocity = 4f;
   [SerializeField]  private float velocityMultiplayer = 1.1f;
   private Rigidbody2D ball;

    // Start is called before the first frame update
    void Start()
    {
        ball = GetComponent<Rigidbody2D>();
        BallPlay();
    }

    // Update is called once per frame

     void BallPlay(){

        float x = Random.Range(0,2) == 0 ? 1 : -1;
        float y = Random.Range(0,2) == 0 ? 1 : -1;
        ball.velocity = new Vector2(x, y) * initialVelocity;
}

private void OnTriggerEnter2D(Collider2D collision) {

    if(collision.gameObject.CompareTag("Player1")){
    GameManager.Instance.Paddle1Score();
    GameManager.Instance.Restart();
    BallPlay();
    }
    else{
        GameManager.Instance.Paddle2Score();
         GameManager.Instance.Restart();
         BallPlay();
    }
}
    
}
