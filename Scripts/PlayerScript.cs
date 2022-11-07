using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

// Made by Snowly & Sy3rena
public class PlayerScript : MonoBehaviour
{
    private Rigidbody2D rb;
    private SpriteRenderer sr;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
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
    }
}
