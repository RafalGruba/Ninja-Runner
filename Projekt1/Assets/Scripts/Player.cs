using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // config
    [SerializeField] float runSpeed = 25f;
    [SerializeField] float jumpSpeed = 25f;

    // states
    bool isInTheAir;

    // Cached component references
    Rigidbody2D myRigidBody;
    BoxCollider2D myBodyCollider;
    PolygonCollider2D myFeet;
    Animator myAnimator;
    float gravityScaleAtStart;
    public bool cdFinished = false;

    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
        myBodyCollider = GetComponent<BoxCollider2D>();
        myFeet = GetComponent<PolygonCollider2D>();
        myAnimator = GetComponent<Animator>();
        gravityScaleAtStart = myRigidBody.gravityScale;
        myAnimator.SetTrigger("GameStarted");
        myRigidBody.velocity = new Vector2(0f, myRigidBody.velocity.y);

    }


    void Update()
    {
        FlipSprite();
    }

    private void FixedUpdate()
    {
        if(cdFinished)
        {
            Run();
            Jump();
        }
    }

    private void Run()
    {
        float controlThrow = Input.GetAxis("Horizontal");
        Vector2 playerVelocity = new Vector2(controlThrow * runSpeed, myRigidBody.velocity.y);
        myRigidBody.velocity = playerVelocity;
        bool playerHasHorizontalSpeed = Mathf.Abs(myRigidBody.velocity.x) > Mathf.Epsilon;
        myAnimator.SetBool("isRunning", playerHasHorizontalSpeed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Equals ("Platform"))
        {
            this.transform.parent = collision.transform;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.name.Equals ("Platform"))
        {
            this.transform.parent = null;
        }
    }


    private void Jump()
    {
        if (myFeet.IsTouchingLayers(LayerMask.GetMask("Foreground")) || myFeet.IsTouchingLayers(LayerMask.GetMask("Platform"))) 
        {
            isInTheAir = false;
        }
        if (Input.GetButton("Jump") && (isInTheAir == false))
        {
            isInTheAir = true;
            Vector2 jumpVelocity = new Vector2(0f, jumpSpeed);
            myRigidBody.velocity += jumpVelocity;
            myAnimator.SetTrigger("hasJumped");
            Debug.Log("I've pressed SPACE button only once");
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
    public void CdFinished()
    {
        cdFinished = true;
    }

}
