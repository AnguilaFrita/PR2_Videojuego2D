using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class GameOverScript : MonoBehaviour
{
    GameObject gameoverScreen; 

    // Start is called before the first frame update
    void Start()
    {
        gameoverScreen = GameObject.Find("gameOver");
        gameoverScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.vidas <= 0){
        gameoverScreen.SetActive(true);
        }
       
    }

    public void Retry(){
        SceneManager.LoadScene("jueguito");
    }
    
    
}
