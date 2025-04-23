using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{

    public AudioSource m_audioSource;
    public AudioClip bandaSonora;
    public AudioClip sonidoMonea;
    public AudioClip sonidoPupa;
    public AudioClip sonidoBotones;
    public AudioClip sonidoBala;

    public static Audio Instance;

    void Awake()
    {
        if (Instance != null && Instance != this){
            Destroy(this);
        }else{
            Instance = this;
             DontDestroyOnLoad(this.gameObject);
        }

       
    }
    // Start is called before the first frame update
    void Start()
    {
        m_audioSource = GetComponent<AudioSource>();
        m_audioSource.clip = bandaSonora;
        m_audioSource.loop = true;
        m_audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //método sonar clip
    public void SonarClip(AudioClip ac){
        m_audioSource.PlayOneShot(ac);
    }

}
