using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleControl : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed;
    public KeyCode upKey;
    public KeyCode downKey;
    private Rigidbody2D rig;


    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    public void ActivatePUPaddleSpeed(float magnitude)
    {
        StartCoroutine(PaddleSpeedTimeOut(magnitude));
    }


    public void ActivateLongPaddle(GameObject paddle)
    {
        StartCoroutine(LongPaddleTimeOut(paddle));
    }

    IEnumerator LongPaddleTimeOut(GameObject paddleLongCor)
    {
         paddleLongCor.transform.localScale += new Vector3 (0,2,0);
         yield return new WaitForSeconds(5);
         paddleLongCor.transform.localScale += new Vector3 (0,-2,0);
    }

    IEnumerator PaddleSpeedTimeOut(float magnitudeCor)
    {
         speed *= magnitudeCor;
         yield return new WaitForSeconds(5);
         speed /= magnitudeCor;
    }

    // Update is called once per frame
    void Update()
    {

        MoveObject(GetInput());
    }

    private Vector2 GetInput()
    {
        if (Input.GetKey(upKey))
        {
            return Vector3.up * speed;
        }
        if (Input.GetKey(downKey))
        {
            return Vector3.down * speed;
        }

        return Vector2.zero;

    }

    private void MoveObject(Vector2 movement)
    {
        rig.velocity = movement;
        Debug.Log("Test: " + movement);
    }
}
