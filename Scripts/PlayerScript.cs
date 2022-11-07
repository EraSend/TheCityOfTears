using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

// Made by Snowly & Sy3rena
public class PlayerScript : MonoBehaviour
{
    private Rigidbody2D rb;
    private SpriteRenderer sr;
    private bool OnGround;
    public Transform GroundCheck;
    private float RadiusCheck = 0.23f;
    public LayerMask Ground;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        CheckingGround();

        if (Input.GetKey(KeyCode.A))
        {
            transform.localPosition += -transform.right * BaseClassScript.PlayerSpeed * Time.deltaTime;
            sr.flipX = false;
        }

        else if (Input.GetKey(KeyCode.D))
        {
            transform.localPosition += transform.right * BaseClassScript.PlayerSpeed * Time.deltaTime;
            sr.flipX = true;
        }
        
        else if (Input.GetKeyDown(KeyCode.Space) && OnGround)
        {
            rb.velocity = new Vector2(rb.velocity.x, BaseClassScript.JumpForce);
        }
    }

    private void CheckingGround()
    {
        OnGround = Physics2D.OverlapCircle(GroundCheck.position, RadiusCheck, Ground);
    }
}
