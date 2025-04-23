using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    GameObject miCamara;
    public float parallaxSpeed = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        miCamara = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Camera.main.transform.position);
        

    }

    void FixedUpdate()
    {
      transform.position = new Vector3(Camera.main.transform.position.x/parallaxSpeed,0 , 0);
    }
}
