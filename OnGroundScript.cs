using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnGroundScript : MonoBehaviour
{
    GameObject Player;

    void Start()
    {
        Player = gameObject.transform.parent.gameObject;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Ground")
        {
            Player.GetComponent<PlayerScript>().onPlatform = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        Player.GetComponent<PlayerScript>().onPlatform = false;
    }
}
