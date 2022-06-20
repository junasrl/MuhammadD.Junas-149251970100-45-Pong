using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    // Start is called before the first frame update

    public Vector2 speed;
    private Rigidbody2D rig;

    public string LastPaddle;
    public int isPaddleRight;

    public Vector2 resetPosition;
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        rig.velocity = speed;
    }

    public void ActivatePUSpeedUp(float magnitude)
    {
        rig.velocity *= magnitude;
    }

    private void OnCollisionEnter2D(Collision2D collisioninfo) 
    {
        string collider_tag = collisioninfo.collider.tag;
        string collider_name = collisioninfo.collider.name;

        if (collider_tag == "Paddle")
        {
            LastPaddle = collider_name;
        }

    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void ResetBall()
    {
        transform.position = new Vector3(resetPosition.x, resetPosition.y, 2);
    }
}
