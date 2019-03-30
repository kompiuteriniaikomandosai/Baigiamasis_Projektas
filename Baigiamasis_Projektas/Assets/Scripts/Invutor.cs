﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invutor : MonoBehaviour {
    public Sprite bottleImg;
    public Sprite defaultImg;
    public slot[] slots;
    public Troskulis troskulis;


	void Start () {
		
	}
	
	void Update () {

        if (Input.GetKeyDown(KeyCode.Q))
        {
            int j = 0;
            while( j < slots.Length)
            {
                if(slots[j].slotTaken == false)
                {
                    Debug.Log("SLOT NR : " + j + " IS FREE");
                    slots[j].slotTaken = true;
                    slots[j].slotItem.sprite = bottleImg;
                    slots[j].itemName = "Bottle";
                    break;
                    //Tikrina ar slotas yra uzimtas
                }

                j++;
            }
        }
	}   

    public void UseInventoryItem(int i)
    {
        if(slots[i].itemName == "Bottle")
        {
            if (troskulis.Truskolis + 50 < 100)
                troskulis.Truskolis += 50;
            else
                troskulis.Truskolis = 100;

            slots[i].slotTaken = false;
            slots[i].slotItem.sprite = defaultImg;
            slots[i].itemName = "";

        }

        
        
    }

 

   

}

