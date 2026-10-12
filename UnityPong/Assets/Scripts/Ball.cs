using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public GameManager gameManager;
    public Rigidbody2D rb2d;
    public float maxInitialAngel = 0.67f;
    public float movespeed = 1f;
    public float MaxStartY = 4f;

    private float startX = 0f;

    private void Start()
    {
        Initialpush();
    }

    private void Initialpush()
    {
        Vector2 dir = Random.value < 0.5f ? Vector2.left : Vector2.right;

        dir.y = Random.Range(-maxInitialAngel, maxInitialAngel);
        rb2d.velocity = dir * movespeed;
    }

    private void ResetBall()
    {
        float posY = Random.Range(-MaxStartY, MaxStartY);
        Vector2 posisition = new Vector2(startX, posY);
        transform.position = posisition;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        ScoreZone scoreZone = collision.GetComponent<ScoreZone>();
        if(scoreZone)
        {
            gameManager.OnScoreZoneReached(scoreZone.id);
            ResetBall();
            Initialpush();
        }   
    }
}
