using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoIntroScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Invoke("GoIntroScene1", 3);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void GoIntroScene1()
    {
        SceneManager.LoadScene(1);
    }
}
