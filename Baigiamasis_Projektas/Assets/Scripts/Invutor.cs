using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invutor : MonoBehaviour {
    public Sprite bottleImg;
    public Sprite AppleImg;
    public Sprite defaultImg;
    public slot[] slots;
    public Busena busena;


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
                    slots[j].slotTaken = true;
                    slots[j].slotItem.sprite = bottleImg;
                    slots[j].itemName = "Bottle";
                    break;
                    //Tikrina ar slotas yra uzimtas
                }

                j++;
            }

         
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            int e = 0;
            while (e < slots.Length)
            {
                if (slots[e].slotTaken == false)
                {
                    slots[e].slotTaken = true;
                    slots[e].slotItem.sprite = AppleImg;
                    slots[e].itemName = "Apple";
                    break;
                    //Tikrina ar slotas yra uzimtas
                }

                e++;
            }
        }

    }   

    public void UseInventoryItem(int i)
    {
        if(slots[i].itemName == "Bottle")
        {
            if (busena.Truskolis + 50 < 100)
                busena.Truskolis += 50;
            else
                busena.Truskolis = 100;

            slots[i].slotTaken = false;
            slots[i].slotItem.sprite = defaultImg;
            slots[i].itemName = "";

        }

        if (slots[i].itemName == "Apple")
        {
            if (busena.Alkis + 50 < 100)
                busena.Alkis += 50;
            else
                busena.Alkis = 100;

            slots[i].slotTaken = false;
            slots[i].slotItem.sprite = defaultImg;
            slots[i].itemName = "";

        }



    }

 

   

}

