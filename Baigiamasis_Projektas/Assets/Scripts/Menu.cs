using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

	// Use this for initialization
	void Start () {
       

    }
	
	// Update is called once per frame
	void Update () {
		
	}

   public void PlayGame()
    {
        SceneManager.LoadScene(2);
    }
    public void GoControls()
    {
        SceneManager.LoadScene(3);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
    public void GoMenu()
    {
        SceneManager.LoadScene(1);
    }
}
