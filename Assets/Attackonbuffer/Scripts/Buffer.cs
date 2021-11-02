using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buffer : MonoBehaviour
{
    public static int health;

    void Start()
    {
        health = 10;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            health--;
        }
    }

    void Update()
    {
        if (health == 0)
        {
            Destroy(gameObject);
        }
    }
}
