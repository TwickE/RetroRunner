using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollectorPlayer2 : MonoBehaviour
{
    private int coinCount = 0;

    [SerializeField] private Text coinsText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Coin"))
        {
            Destroy(collision.gameObject);
            coinCount++;
            coinsText.text = "Coins Player 2: " + coinCount;
        }
    }
}
