using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] float speed = 1f;
    Rigidbody2D myRigidBody;

    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isFacingRight())
        {
            myRigidBody.velocity = new Vector2(speed, 0f);
        }
        else
        {
            myRigidBody.velocity = new Vector2(-speed, 0f);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        transform.localScale = new Vector2(-(Mathf.Sign(myRigidBody.velocity.x) * 2), 2f);
    }
    bool isFacingRight()
    {
        return transform.localScale.x > 0;
    }
}
