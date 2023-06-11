using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;

    private bool isMuted = false;

    [SerializeField] private Button targetButton;
    private Image buttonImage;
    [SerializeField] private Sprite image1;
    [SerializeField] private Sprite image2;

    // Start is called before the first frame update
    void Start()
    {
        buttonImage = targetButton.image; // Get the Image component of the button
    }

    public void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }

    public void ToggleSound()
    {
        isMuted = !isMuted;

        if(isMuted)
        {
            AudioListener.volume = 0;
            buttonImage.sprite = image2;
        }
        else
        {
            AudioListener.volume = 1;
            buttonImage.sprite = image1;
        }
    }
}
