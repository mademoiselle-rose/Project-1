using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBird : MonoBehaviour
{

    public bool isDead;
    public float velocity = 1f;
    public Rigidbody2D rb2D;
    public GameManager mnggame;
    public GameObject DeadScreen;

    private void Start()
    {
        Time.timeScale = 1;
    }

    void Update()
    {
       if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            rb2D.velocity = Vector2.up * velocity ;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name== "ScoreArea")
        {
            mnggame.UpdateScore();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="DeadArea")
        {
            isDead = true;
            Time.timeScale = 0;
            DeadScreen.SetActive(true);
        }
    }
}
