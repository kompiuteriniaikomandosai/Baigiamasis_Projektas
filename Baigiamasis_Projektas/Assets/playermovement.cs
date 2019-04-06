using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour   
{
    public float speed = 1;
    public float maxForwardSpeed;
    public float timer;
    //public float time =0;
   
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * speed * maxForwardSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * speed * maxForwardSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.up * speed * maxForwardSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
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