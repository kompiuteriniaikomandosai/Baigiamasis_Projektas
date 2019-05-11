using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour   
{
    public float speed = 1;
    public float maxForwardSpeed;
    public float timer;
    //public float time =0;

 //   public GameObject helloText;
 //   public GameObject wasdText;
  //  public GameObject shiftTxt;

    bool pradingoVienakarta = false;
   
    // Use this for initialization
    void Start()
    {
       // helloText.SetActive(true);

       // Invoke("OFF", 2);
    }

    void OFF()
    {
       // helloText.SetActive(false);
       // wasdText.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.D))
        {
          //  wasdText.SetActive(false);
            transform.position += Vector3.right * speed * maxForwardSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
          //  wasdText.SetActive(false);
            transform.position += Vector3.left * speed * maxForwardSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.W))
        {
           // wasdText.SetActive(false);
            transform.position += Vector3.up * speed * maxForwardSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
          //  wasdText.SetActive(false);
            transform.position += Vector3.down * speed * maxForwardSpeed *  Time.deltaTime;
        }


        if (Input.GetKey(KeyCode.LeftShift))
        {
            if(timer < 5)
            timer += Time.deltaTime;

            if (timer < 5)
                maxForwardSpeed = 1.8f;
            else
                maxForwardSpeed = 1;
        }
        else
        {
            timer -= Time.deltaTime;
           if(timer <= 0)
           timer = 0;
            maxForwardSpeed = 1;

        }
        


        
    }

   


    }



