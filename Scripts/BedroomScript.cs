using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

// Start Scene Script
public class BedroomScript : MonoBehaviour
{
    private SpriteRenderer sr;
    
    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Player" && Input.GetKey(KeyCode.F))
        {
            SceneManager.LoadScene("2lvl");
        }
    }
}
