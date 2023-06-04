using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollectorPlayer2 : MonoBehaviour
{
    private int coinCount = 0; //Number of coins the plyer2 has

    [SerializeField] private Text coinsText;

    [SerializeField] private AudioSource collectionSoundEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Coin"))
        {
            collectionSoundEffect.Play(); //Plays the collection sound effect
            Destroy(collision.gameObject); //Destroys the coin
            coinCount++; //Adds 1 to the coinCount
            coinsText.text = coinCount.ToString(); //Updates the text
        }
    }
}
