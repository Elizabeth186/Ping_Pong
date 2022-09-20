using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Players : MonoBehaviour
{
    public float velocidad = 0.5f;
     public string playerName = "Jugador1"; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         float vertitalplayer = Input.GetAxis(playerName) * velocidad;

        Vector2 player = new Vector2(0f, vertitalplayer);
        
        transform.Translate(player);

         if(transform.position.y >2.30f){
            Vector2 positionnew = new Vector2(transform.position.x,2.30f);
            transform.position = positionnew;
        }else if(transform.position.y < -2.30f){
             Vector2 positionnew = new Vector2(transform.position.x, -2.30f);
            transform.position = positionnew;
        }

    }

    }

