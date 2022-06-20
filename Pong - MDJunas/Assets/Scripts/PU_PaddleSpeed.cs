using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PU_PaddleSpeed : MonoBehaviour
{
    // Start is called before the first frame update
    public Collider2D ball;
    public GameObject PaddleLeft;
    public GameObject PaddleRight;
    public float magnitude;
    // Start is called before the first frame update
    public BallControl ballcontrol;
    public PowerUpManager manager;
    

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision == ball)
        {
            if (ballcontrol.LastPaddle == "Paddle1")
            {
                PaddleLeft.GetComponent<PaddleControl>().ActivatePUPaddleSpeed(magnitude);
                manager.RemovePowerUp(gameObject);
            }

            else if (ballcontrol.LastPaddle == "Paddle2")
            {
                PaddleRight.GetComponent<PaddleControl>().ActivatePUPaddleSpeed(magnitude);
                manager.RemovePowerUp(gameObject);
            }

        }
    }
}
