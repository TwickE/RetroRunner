using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] private Text timerText;
    private float currentTime;

    // Update is called once per frame
    void Update()
    {
        // Update the timer
        currentTime += Time.deltaTime;

        // Convert time elapsed to minutes and seconds
        int minutes = Mathf.FloorToInt(currentTime / 60f);
        int seconds = Mathf.FloorToInt(currentTime % 60f);

        // Format the minutes and seconds with leading zeros
        string minutesFormatted = minutes.ToString("00");
        string secondsFormatted = seconds.ToString("00");

        // Update the timer text
        timerText.text = minutesFormatted + ":" + secondsFormatted;
    }
}
