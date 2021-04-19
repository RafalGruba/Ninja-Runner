using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // config
    [SerializeField] float runSpeed = 5f;
    [SerializeField] float jumpSpeed = 5f;

    // states

    // Cached component references
    Rigidbody2D myRigidBody;
    BoxCollider2D myBodyCollider;
    PolygonCollider2D myFeet;

    // Start is called before the first frame update
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
        myBodyCollider = GetComponent<BoxCollider2D>();
        myFeet = GetComponent<PolygonCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Run();
        Jump();
    }

    private void Run()
    {
        float controlThrow = Input.GetAxis("Horizontal");
        Vector2 playerVelocity = new Vector2(controlThrow * runSpeed, myRigidBody.velocity.y);
        myRigidBody.velocity = playerVelocity;
    }

    private void Jump()
    {
        if (!myFeet.IsTouchingLayers(LayerMask.GetMask("Foreground"))) { return; }
        if (Input.GetButtonDown("Jump"))
        { 
        Vector2 jumpVelocity = new Vector2(0f, jumpSpeed);
        myRigidBody.velocity = jumpVelocity;
        }
    }

}
