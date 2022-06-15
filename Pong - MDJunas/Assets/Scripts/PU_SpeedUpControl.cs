using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PU_SpeedUpControl : MonoBehaviour
{

    public Collider2D ball;
    public float magnitude;
    // Start is called before the first frame update

    public PowerUpManager manager;
    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision == ball)
        {
            ball.GetComponent<BallControl>().ActivatePUSpeedUp(magnitude);
            manager.RemovePowerUp(gameObject);

        }
    }
}
