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
    Animator myAnimator;
    float gravityScaleAtStart;

    // Start is called before the first frame update
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
        myBodyCollider = GetComponent<BoxCollider2D>();
        myFeet = GetComponent<PolygonCollider2D>();
        myAnimator = GetComponent<Animator>();
        gravityScaleAtStart = myRigidBody.gravityScale;
        myAnimator.SetTrigger("GameStarted");

    }

    // Update is called once per frame
    void Update()
    {
        FlipSprite();
        Run();
        Jump();
    }

    private void Run()
    {
        float controlThrow = Input.GetAxis("Horizontal");
        Vector2 playerVelocity = new Vector2(controlThrow * runSpeed, myRigidBody.velocity.y);
        myRigidBody.velocity = playerVelocity;
        bool playerHasHorizontalSpeed = Mathf.Abs(myRigidBody.velocity.x) > Mathf.Epsilon;
        myAnimator.SetBool("isRunning", playerHasHorizontalSpeed);
    }

    private void Jump()
    {
        if (!myFeet.IsTouchingLayers(LayerMask.GetMask("Foreground"))) { return; }
        if (Input.GetButtonDown("Jump"))
        { 
        Vector2 jumpVelocity = new Vector2(0f, jumpSpeed);
        myRigidBody.velocity += jumpVelocity;
        myAnimator.SetTrigger("hasJumped");
        }
    }

    private void FlipSprite()
    {

        bool playerHasHorizontalSpeed = Mathf.Abs(myRigidBody.velocity.x) > Mathf.Epsilon;
        if (playerHasHorizontalSpeed)
        {
            myRigidBody.gravityScale = gravityScaleAtStart;
            transform.localScale = new Vector2(Mathf.Sign(myRigidBody.velocity.x), 1f);
        }

    }

}
