using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public int moveSpeed = 7;
    private Vector3 movement;
    public float jumpHeight = 5f;
    public bool onPlatform = true;
    public Sprite[] sprites;

    void Update()
    {
        movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position = transform.position +  movement * moveSpeed * Time.deltaTime;
        Jump();

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            GetComponent<SpriteRenderer>().sprite = sprites[0];
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            GetComponent<SpriteRenderer>().sprite = sprites[1];
        }
    }

    void Jump()
    {
        if (Input.GetButtonDown("Jump") && onPlatform)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpHeight), ForceMode2D.Impulse);
        }
    }
}
