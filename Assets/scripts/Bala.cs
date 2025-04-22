using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bala : MonoBehaviour
{

    public float velocidad = 1f;

    public int potenciaArma = 1;

    GameObject personaje;

    bool balaDerecha = true;

    float tiempoDestruccion = 5f;

    float quehoraes;

    // Start is called before the first frame update
    void Start()
    {
        personaje = GameObject.Find("knight");
        balaDerecha = personaje.GetComponent<MovPersonaje>().miraDerecha;
        quehoraes = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        float VelocidadFinal = velocidad *Time.deltaTime;
         transform.Translate(VelocidadFinal,0,0);

        if (balaDerecha){
            transform.Translate(VelocidadFinal, 0, 0, Space.World);
        }else{
            transform.Translate(VelocidadFinal *-1, 0, 0, Space.World);
        }
        
        if(Time.time >= quehoraes+tiempoDestruccion){
            Destroy(this.gameObject);
        }
    }


    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name.StartsWith("enemigo_fantasma")){
            Destroy(this.gameObject);
            col.gameObject.GetComponent<Fantasma>().vidaFantasma -= potenciaArma;
        }
        if(gameObject.GetComponent<Fantasma>().vidaFantasma == 0){
            GameManager.muertes +=1;
        }

    }



}
