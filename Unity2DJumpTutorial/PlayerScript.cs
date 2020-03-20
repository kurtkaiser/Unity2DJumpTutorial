using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public int moveSpeed = 7;
    private Vector3 movement;
    public float jumpHeight = 5f;
    public bool onPlatform = true;

    void Update()
    {
        movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position = transform.position +  movement * moveSpeed * Time.deltaTime;
        Jump();
    }

    void Jump()
    {
        if (Input.GetButtonDown("Jump") && onPlatform)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpHeight), ForceMode2D.Impulse);
        }
    }
}
