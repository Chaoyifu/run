using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombScript : MonoBehaviour {

    public float speed = 15f;
    private float startingPositionX;
    public float endingPositionX = 32f;
    private float distance;
    private float originalDistance;
    private float originalPositionX;
    private float originalTargetX;
    private bool flag = true;



    void Start()
    {
        startingPositionX = transform.position.x;
        distance = endingPositionX - startingPositionX;
        originalDistance = endingPositionX - startingPositionX;
        originalPositionX = transform.position.x;
        originalTargetX = endingPositionX;
    }


    void FixedUpdate()
    {
        if (distance >= 0)
        {
            if (flag)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(speed, GetComponent<Rigidbody2D>().velocity.y);
                distance = endingPositionX - transform.position.x;
            }
            else
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(-speed, GetComponent<Rigidbody2D>().velocity.y);
                distance = -1 * (endingPositionX - transform.position.x);
            }
        }
        else if (distance <= 0)
        {
            if (flag)
            {
                flag = false;
                startingPositionX = originalPositionX + endingPositionX;
                endingPositionX = originalPositionX;
                Flip();
                GetComponent<Rigidbody2D>().velocity = new Vector2(-speed, GetComponent<Rigidbody2D>().velocity.y);
                distance = Mathf.Abs(endingPositionX - transform.position.x);
            }
            else {
                flag = true;
                startingPositionX = originalPositionX;
                endingPositionX = originalTargetX;
                Flip();
                GetComponent<Rigidbody2D>().velocity = new Vector2(speed, GetComponent<Rigidbody2D>().velocity.y);
                distance = Mathf.Abs(endingPositionX - transform.position.x);
            }
        }
    }

    void Flip()
    {
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.name == "Player") {
            Destroy(coll.gameObject);
            Time.timeScale = 0;
        }

    }
}
