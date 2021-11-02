using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class ScriptScore : MonoBehaviour
{
    public static bool win2 = false;
    public Text txt;
    public static int numvir;

    // Use this for initialization
    void Start()
    {
        txt.text = "Virus restantes: ";
        numvir = 8;
    }

    // Update is called once per frame
    void Update()
    {
        txt.text = "Virus restantes: @ " + numvir;
        txt.text = txt.text.Replace("@", System.Environment.NewLine);

         if (numvir <=0)
        {
            SceneManager.LoadScene("Win");
            win2 = true;
        }

    }
}

