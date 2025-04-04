using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovPersonaje : MonoBehaviour
{

    public float velocidad = 4;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float MovTeclas = Input.GetAxis("Horizontal");

        if(MovTeclas>0){
            this.GetComponent<SpriteRenderer>().flipX = false;
           // this.GetComponent<Animator>().SetBool("activaCaminar", true);
        }
        if(MovTeclas<0){
            this.GetComponent<SpriteRenderer>().flipX = true;
           // this.GetComponent<Animator>().SetBool("activaCaminar", true);
        }

        /*if(MovTeclas == 0){
         this.GetComponent<Animator>().SetBool("activaCaminar", true);
        }*/

        
    
        

        float miDeltaTime = Time.deltaTime;

        //Debug.Log(Input.GetAxis("Horizontal"));

    }
}
