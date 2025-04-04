using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{

    public float velocidad = 1;

    public int potenciaArma = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float VelocidadFinal = velocidad * Time.deltaTime;
         transform.Translate(VelocidadFinal,0,0);

    
        
    }


    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name.StartsWith("enemigo_fantasma")){
            Destroy(this.gameObject);
            col.gameObject.GetComponent<Fantasma>().VidaFantasma -= potenciaArma;
        }

    }



}
