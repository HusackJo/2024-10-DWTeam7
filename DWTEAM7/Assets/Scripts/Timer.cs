using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField]
    private float timeCounter;
    [SerializeField]
    private int seconds;
    [SerializeField]
    private int minutes;
    [SerializeField]
    private TextMeshProUGUI timerText;

    void Update()
    {
        timeCounter += Time.deltaTime;
        minutes = Mathf.FloorToInt(timeCounter / 60f);
        seconds = Mathf.FloorToInt(timeCounter - minutes *60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
