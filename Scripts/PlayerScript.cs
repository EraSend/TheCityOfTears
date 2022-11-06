using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S : MonoBehaviour
Rigidbody2D a
{
    // by snowly
    void Start()
    {
        a = GetComponet<Rigidbody2D>();
        sr = GetComponet<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float movement = Input.GetAxis("Hotizontal");
        transform.position += new Vector3(movement, 0, 0) * speed * Time.delta.Time;

        if(Input.GetKeyDown(KeyCode.Space) && MAthf.Abs(a.velocity.y) <0.05f);
          a.AddForce(new Vector2(0, 1));

          sr.flipX = movement < 0 ? true : false;
    }
}
