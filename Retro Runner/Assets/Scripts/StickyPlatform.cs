using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickyPlatform : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Player1" || collision.gameObject.name == "Player2") //If the object that collided with the platform is the player
        {
            collision.gameObject.transform.SetParent(transform); //Set the player's parent to the platform
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Player1" || collision.gameObject.name == "Player2") //If the object that collided with the platform is the player
        {
            collision.gameObject.transform.SetParent(null); //Set the player's parent to null
        }
    }
}
