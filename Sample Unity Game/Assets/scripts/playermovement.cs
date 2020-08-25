using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    public float speed = 1000;
    public float sidespeed = 500;
    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0,0,speed*Time.deltaTime);

        if(Input.GetKey("d")){
            rb.AddForce(sidespeed*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }else if (Input.GetKey("a")){
            rb.AddForce(-1*sidespeed*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }

        if(rb.position.y<-1f){
            FindObjectOfType<gameman>().EndGame();
        }
    }
}
