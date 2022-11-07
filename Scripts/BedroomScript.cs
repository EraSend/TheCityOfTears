using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Start Scene Script
public class BedroomScript : MonoBehaviour
{
    private SpriteRenderer sr;
    
    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            
        }
    }
}