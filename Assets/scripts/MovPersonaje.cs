using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovPersonaje : MonoBehaviour
{

    public float velocidad = 4;
    public float multiplicadorSalto = 5;
    private Rigidbody2D rb;

    private bool puedoSaltar = true;

    private Animator animatorController;

    GameObject Respawn;

    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D> ();

        animatorController = this.GetComponent<Animator>();

        Respawn = GameObject.Find("respawn");

        transform.position = Respawn.transform.position;

    
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.Mortaja) return;


        //movimiento

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

        rb.velocity = new Vector2(MovTeclas, rb.velocity.y);

        float miDeltaTime = Time.deltaTime;

        //Debug.Log(Time.deltaTime);

        transform.Translate(
            MovTeclas*(Time.deltaTime*velocidad),
            0,
            0
        );

        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 0.5f);
        Debug.DrawRay(transform.position, Vector2.down, Color.magenta);

        if(hit){
            puedoSaltar = true;
            
        }else{
            puedoSaltar = false;
        }

        //salto

        if(Input.GetKeyDown(KeyCode.Space) && puedoSaltar)
        {
            rb.AddForce(new Vector2
            (0,multiplicadorSalto),
            ForceMode2D.Impulse
            );
            // puedoSaltar = false;
        }
            

            
            if(MovTeclas == 0){
                animatorController.SetBool("ActivaCamina", false);
            }else{
                animatorController.SetBool("ActivaCamina", true);
            }



        if(transform.position.y <= -10){
            respawnear();
        }


        //0 vidas
        if(GameManager.vidas <= 0){
            GameManager.Mortaja = true;
        }
    

    }

    void OnCollisionEnter2D(){
       puedoSaltar = true;

    }


    public void respawnear(){

        Debug.Log("vidas: "+GameManager.vidas);
        GameManager.vidas = GameManager.vidas -1;
        Debug.Log("vidas: "+GameManager.vidas);

        transform.position = Respawn.transform.position;
    }

    
    
}
