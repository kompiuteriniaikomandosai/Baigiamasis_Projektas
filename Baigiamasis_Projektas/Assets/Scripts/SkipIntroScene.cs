using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SkipIntroScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Invoke("GoMenuScene", 10);
        

    }

    void GoMenuScene()
    {
        SceneManager.LoadScene(2);
    }

   

    // Update is called once per frame
    void Update () {
		
	}
}
