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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeCounter += Time.deltaTime;
        minutes = Mathf.FloorToInt(timeCounter / 60f);
        seconds = Mathf.FloorToInt(timeCounter - minutes *60);
    }
}
