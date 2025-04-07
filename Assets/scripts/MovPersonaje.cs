using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovPersonaje : MonoBehaviour
{

    public float velocidad = 4;
    public float multiplicadorSalto = 5;
    private Rigidbody2D rb;

    private bool puedoSaltar = true;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D> ();
        
    }

    // Update is called once per frame
    void Update()
    {

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

        Debug.Log(Time.deltaTime);

        transform.Translate(
            MovTeclas*(Time.deltaTime*velocidad),
            0,
            0
        );

        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 0.5f);
        Debug.DrawRay(transform.position, Vector2.down, Color.magenta);

        if(hit){
            puedoSaltar = true;
            Debug.Log(hit.collider.name);
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
        //Debug.Log(Input.GetAxis("Horizontal"));

    }

    void OnCollisionEnter2D(){
       puedoSaltar = true;

    }
}
