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
        SceneManager.LoadScene(3);
    }
    public void GoControls()
    {
        SceneManager.LoadScene(4);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
    public void GoMenu()
    {
        SceneManager.LoadScene(2);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "HouseDoors")
        {
            GoHouse();
        }
            
    }
    public void GoHouse()
    {
        SceneManager.LoadScene(5);
    }
}
