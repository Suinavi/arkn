using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public Rigidbody2D rb;
    Vector2 forse = new Vector2(1,1);
    public float speed;
    bool isStarted;
    public Pad pad;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (isStarted)
        { 

        }
        else
        {
            transform.position = new Vector3(pad.transform.position.x, pad.transform.position.y+1, 0);
        if (Input.GetMouseButtonDown(0))
        {
            startBall();
        }
        }
    }
    void startBall()
    {
        rb.AddForce(forse * speed);
        isStarted = true;
    }
}
