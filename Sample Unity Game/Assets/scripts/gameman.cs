using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameman : MonoBehaviour
{
    bool end=false;
    public float delay=2f;
    public void EndGame(){
        if(end==false){
            end=true;
            Debug.Log("GG");
            Invoke("Restart",delay);
        }

    }
    void Restart(){
        SceneManager.LoadScene("Level One");
    }
}
