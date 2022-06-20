using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUSpeedUpController : MonoBehaviour
{
    public Collider2D ball;
    public Collider2D paddle;
    public float magnitude;
    public PowerUpManager manager;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == ball)
        {
            //speed up the ball
            ball.GetComponent<BallController>().ActivatePUSpeedUp(magnitude);
            manager.RemovePowerUp(gameObject);
        }
    }
}
