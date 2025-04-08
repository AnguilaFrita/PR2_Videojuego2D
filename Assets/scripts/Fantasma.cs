using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fantasma : MonoBehaviour
{
    public int vidaFantasma = 5;
    public float velocidad = 1;
    public float limiteDerecha = 2;
    public float limiteIzquierda = 2;

    private Vector3 poseLimDcha;
    private Vector3 poseLimIzda;
    private bool direccionFantasma = true;
    private Vector3 poseInicial;
    private bool estadoFantasma = "Patrol";
    
   
    private GameObject player;

    private float distancia;
    public float distanciaAtaque = 2;
    public float distanciaPatrol = 10;
    public float velocidadAtaque = 2;

    // Start is called before the first frame update
    void Start()
    {
       poseInicial = transform.position; 
        poseLimDcha = new Vector3(poseInicial.x +limiteDerecha, poseInicial.y, 0);
        poseLimIzda = new Vector3(poseInicial.x -limiteIzquierda, poseInicial.y, 0);

        player = GameObject.FindWithTag("Player");

        
    }

    // Update is called once per frame
    void Update()
  {
      if(vidaFantasma <= 0){
            Destroy(this.gameObject);
          }  

      if(estadoFantasma == "Patrol")
        {
          if(direccionFantasma == true){
            transform.Translate(velocidad*Time.deltaTime, 0, 0);
            this.GetComponent<SpriteRenderer>().flipX = true;
          }
          if(direccionFantasma == false){
            transform.Translate((velocidad*Time.deltaTime)*-1, 0, 0);
            this.GetComponent<SpriteRenderer>().flipX = false;
          }

          if(transform.position.x >= poseLimDcha.x){
            direccionFantasma = false;
          }
          if(transform.position.x <= poseLimIzda.x){
            direccionFantasma = true;
          }
        
          distancia = Vector3.Distance(transform.position, player.transform.position);
        }

    if(distancia < distanciaAtaque){
        estadoFantasma = "Ataque";
      }
    if(distancia >= distanciaAtaque){
        estadoFantasma = "Patrol";



    Debug.Log(distancia);
 

    if(estadoFantasma == "Ataque"){
        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, velocidadAtaque*Time.deltaTime);
        if(player.transform.position.x <= transform.position.x){
          this.GetComponent<SpriteRenderer>().flipX = false;
        }else{
          this.GetComponent<SpriteRenderer>().flipX = true;
        }
      }

//lo de abajo es porque me falta el Game Manager script

/* void OnCollisionEnter2D(Collision2D col){
    if(col.gameObject.tag == "Player"){
        GameManager.vida -= 1;
      }
*/   
    }

  }
}
