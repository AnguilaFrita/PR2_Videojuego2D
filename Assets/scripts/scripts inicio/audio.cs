using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio : MonoBehaviour
{

    public AudioSource m_audioSource;
    public AudioClip bandaSonora;
    public AudioClip sonidoMonea;
    // Start is called before the first frame update
    void Start()
    {
        m_audioSource = GetComponent<AudioSource>();
        m_audioSource.clip = bandaSonora;
        m_audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
