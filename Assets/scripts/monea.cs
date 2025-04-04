using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monea : MonoBehaviour
{

    public int valor = 1;
    
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
            this.GetComponent<Animator>().SetBool("destruir_monea",true);
            Destroy(this.gameObject,1.0f);
        }



    }
}
