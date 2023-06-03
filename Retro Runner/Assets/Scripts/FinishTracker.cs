using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishTracker : MonoBehaviour
{

    public static FinishTracker Instance; // Singleton instance

    private bool player1Checkpoint = false; // Number of checkpoints Player 1 has collided with
    private bool player2Checkpoint = false; // Number of checkpoints Player 2 has collided with


    // Start is called before the first frame update
    void Start()
    {
        if(Instance == null)
        {
            Instance = this; // Set the singleton instance
        }
        else
        {
            Destroy(gameObject); // Destroy the duplicate
        }
    }

    public void PlayerGetCheckpoint(int playerIndex)
    {
        if(playerIndex == 1)
        {
            player1Checkpoint = true;
        }
        else if(playerIndex == 2)
        {
            player2Checkpoint = true;
        }

        if(player1Checkpoint == true && player2Checkpoint == true)
        {
            player1Checkpoint = false;
            player2Checkpoint = false;
            Debug.Log("Level Complete!");
            Invoke("CompleteLevel", 2f);
        }
    }

    private void CompleteLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
