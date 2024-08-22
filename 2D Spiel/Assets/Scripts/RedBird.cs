using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBird : MonoBehaviour
{

    public bool isDead;
    public float velocity = 1f;
    public Rigidbody2D rb2D;
    
    
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            rb2D.velocity = Vector2.up * velocity ;
        }
    }
}
