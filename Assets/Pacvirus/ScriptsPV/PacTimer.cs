using System.Collections;
using System.Collections.Generic;

using UnityEngine.SceneManagement;
using UnityEngine.UI;

using UnityEngine;

public class PacTimer : MonoBehaviour
{
    float timeLeft = 100.0f;
    public Text txt;

    // Update is called once per frame
    void Update()
    {
        txt.text = "Countdown: ";
        timeLeft -= Time.deltaTime;

        float minutes = Mathf.FloorToInt(timeLeft / 60); 
        float seconds = Mathf.FloorToInt(timeLeft% 60);
        //Redondeo de segundos 
        txt.text = string.Format("{0:00}:{1:00}", minutes, seconds);


        if (timeLeft < 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}

