using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;

public class monea : MonoBehaviour
{

    public int valor = 1;


    GameObject AudioManager;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {

        if(col.tag == "Player"){

            //GameManagerDependencyInfo.marcador = GameManagerDependencyInfo.marcador + valor;

            this.GetComponent<Animator>().SetBool("destruir_monea",true);
  
            Destroy(this.gameObject,1.0f);
           
           GameManager.puntos += 1;
        }



    }
}
