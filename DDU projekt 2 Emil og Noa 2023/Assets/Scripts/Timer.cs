using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI TimerText;
    float tim;
    int tim2;
    // Start is called before the first frame update
    void Start()
    {;
        
    }

    // Update is called once per frame
    void Update()
    {

        tim += Time.deltaTime;
        if(tim >= 59)
        {
            tim2 += 1;
            tim = 0;
        }
        string hej = ((tim2).ToString("00")+":"+ (tim).ToString("00"));
        TimerText.text = hej;
    }
}
