using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playeycollision : MonoBehaviour
{
    public playermovement movement;

    void OnCollisionEnter(Collision cinfo)
    {
        if(cinfo.collider.tag=="obstacle"){
            movement.enabled=false;
            FindObjectOfType<gameman>().EndGame();
        }
    }
}
