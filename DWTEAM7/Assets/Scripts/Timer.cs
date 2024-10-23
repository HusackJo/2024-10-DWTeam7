using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
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
    [SerializeField]
    private TextMeshProUGUI bestTime;

    private void Start()
    {
        bestTime.text = PlayerPrefs.GetString("Best Time", "00:00");
    }
    void Update()
    {
        timeCounter += Time.deltaTime;
        minutes = Mathf.FloorToInt(timeCounter / 60f);
        seconds = Mathf.FloorToInt(timeCounter - minutes *60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

        if (timerText.text != PlayerPrefs.GetString("Best Time", "00:00"))
        {
            PlayerPrefs.SetString("Best Time", timerText.text);
        }
        
    }

}
