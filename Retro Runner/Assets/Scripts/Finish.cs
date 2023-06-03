using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    private AudioSource finishSound;

    [SerializeField] private bool isPlayer1;
    private bool p1LevelCompleted = false;
    private bool p2LevelCompleted = false;

    // Start is called before the first frame update
    void Start()
    {
        finishSound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Player1" && !p1LevelCompleted && isPlayer1)
        {
            finishSound.Play();
            p1LevelCompleted = true;
            FinishTracker.Instance.PlayerGetCheckpoint(1);
        }
        if(collision.gameObject.name == "Player2" && !p2LevelCompleted && !isPlayer1)
        {
            finishSound.Play();
            p2LevelCompleted = true;
            FinishTracker.Instance.PlayerGetCheckpoint(2);
        }
    }
}
