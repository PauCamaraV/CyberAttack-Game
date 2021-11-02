using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public static bool win1 = false;
    public float timeLeft = 120.0f;
    
    // Update is called once per frame
   
    void Update()
    {
        
        timeLeft -= Time.deltaTime;
        
        if (timeLeft < 0 && Buffer.health > 0)
        {
            SceneManager.LoadScene("Win");
            win1 = true;
        }
    }
}