using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class PACVIRUSSCENE : MonoBehaviour
{
    int playerCollision = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Aprendiz")
        {
            playerCollision = 1;
        }
    }

    void Update()
    {
        if (playerCollision == 1)
        {
            SceneManager.LoadScene("InicioPacVirus");
        }
    }
}
