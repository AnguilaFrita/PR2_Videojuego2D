using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovPersonaje : MonoBehaviour
{

    public float multiplicador = 4f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float MovTeclas = Input.GetAxis("Horizontal"); //(a -1f - d 1f)

        transform.position = new Vector3(
            transform.position.x+MovTeclas*Time.deltaTime*multiplicador,
            transform.position.y,
            transform.position.z
    
        );

        float miDeltaTime = Time.deltaTime;

        //Debug.Log(Input.GetAxis("Horizontal"));

    }
}
