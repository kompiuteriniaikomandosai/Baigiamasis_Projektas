using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Troskulis : MonoBehaviour {

    public float Truskolis = 100;


	void Start () {
        InvokeRepeating("RemoveThirst", 3.5F,3.5F);
        //Kas 3.5 sekundes nuemame troskuli po viena karta
	}
	
    void RemoveThirst()
    {
        Truskolis--;
        //Atemam troskuli
        Debug.Log("TROSKULYS: " + Truskolis);
    }

	void Update () {
		
	}
}
