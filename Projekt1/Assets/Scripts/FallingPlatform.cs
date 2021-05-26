using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatform : MonoBehaviour
{
    bool plaformTouched = false;
    Rigidbody2D rb;
    public GameObject particleEffect;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (plaformTouched)
        {
            rb.bodyType = RigidbodyType2D.Dynamic;
            // Vector2 pushVelocity = new Vector2(0f, -pushPower);
            // rb.velocity = pushVelocity;
        }
        
    }

    IEnumerator TriggerPlatformFall()
    {
        SfxManager.sfxInstance.audioSource.PlayOneShot(SfxManager.sfxInstance.platformIsAboutToFall);
        GameObject sand = Instantiate(particleEffect);
        sand.transform.position = gameObject.transform.position;
        Destroy(sand, 3);
        yield return new WaitForSeconds(1);
        plaformTouched = true;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            StartCoroutine(TriggerPlatformFall());
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        plaformTouched = false;
        rb.bodyType = RigidbodyType2D.Kinematic;
        rb.velocity = new Vector2(0f, 0f);
        transform.position = transform.parent.position;
    }
}
