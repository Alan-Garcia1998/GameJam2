using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timerText;
    public double time;
    private int frame = 0;
    // Start is called before the first frame update
    void Start()
    {
        time = 0.0f;
        timerText.text = "Score: " + time.ToString();
        int frame = 0;
    }

    // Update is called once per frame
    void Update()
    {

        if(frame == 60){
            time++;
            frame = 0;
        }
        
        timerText.text = "Time Elapsed: " + time.ToString();
        frame++;
    }

}
