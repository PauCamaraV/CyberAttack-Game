using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BufferColor : MonoBehaviour
{
    public GameObject yellowgreen;
    public GameObject yellow;
    public GameObject orange;
    public GameObject red;


    void Update()
    {
        if (Buffer.health == 8)
        {
            yellowgreen.SetActive(true);
        }

        if (Buffer.health == 6)
        {
          yellow.SetActive(true);
        }

        if (Buffer.health == 4)
        {
           orange.SetActive(true);
        }

        if (Buffer.health == 2)
        {
          red.SetActive(true);
        }
    }
}
