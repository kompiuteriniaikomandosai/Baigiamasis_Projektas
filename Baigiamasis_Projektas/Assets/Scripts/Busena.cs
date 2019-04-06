using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Busena : MonoBehaviour {

    public float Alkis = 100;
    public float Truskolis = 100;
    public float hp = 100;
    public float Timer =  1;
    public Image troskolisImg;
    public Image alkisImg;
    public Image hpImg;
    

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

    void RemoveHealth()
    {
         hp--;
    }

    void Update () {

        troskolisImg.fillAmount = Truskolis / 100;
        alkisImg.fillAmount = Alkis / 100;
        hpImg.fillAmount = hp / 100;

        if(Truskolis <= 0 || Alkis <= 0)
        {
            Timer -= Time.deltaTime;

            if (Timer <= 0)
            {
                RemoveHealth();
                Timer = 1;
            }

        }

        if (hp == 0)
        {
            Destroy(gameObject);
        }

        
           



    }
}
