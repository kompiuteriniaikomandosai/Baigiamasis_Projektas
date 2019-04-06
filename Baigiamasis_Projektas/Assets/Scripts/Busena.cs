using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Busena : MonoBehaviour {

    public float Alkis = 100;
    public float Truskolis = 100;
    public Image troskolisImg;
    public Image alkisImg;

    void Start () {
        InvokeRepeating("RemoveThirst", 1.5F,1.5F);
        //Kas 1.5 sekundes nuemame troskuli po viena karta
        InvokeRepeating("RemoveAlkis", 3.5F, 3.5F);
        //Kas 1.5 sekundes nuemame Alki po viena karta
    }

    void RemoveThirst()
    {
        
        Truskolis--;
        //Atemam troskuli
       
    }

    void RemoveAlkis()
    {
        Alkis--;
    }

	void Update () {

        troskolisImg.fillAmount = Truskolis / 100;
       alkisImg.fillAmount = Alkis / 100;


    }
}
