using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class CambiaBotones : MonoBehaviour 
{
	public void ChangeScene(string scene)
	{
		SceneManager.LoadScene(scene);
        if (scene == "Quit")
            Application.Quit();
	}

}

