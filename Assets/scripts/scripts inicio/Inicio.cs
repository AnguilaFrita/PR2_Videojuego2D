using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  

public class Inicio : MonoBehaviour
{
    GameObject panelSettings;
    
    GameObject AudioManager;
    audio miAudioManager;

    // Start is called before the first frame update
    void Start()
    {
        panelSettings = GameObject.Find("Settings");
        panelSettings.SetActive(false);

        AudioManager = GameObject.Find("AudioManager");
        miAudioManager = AudioManager.GetComponent<audio> ();
        panelSettings.SetActive(true);
        miAudioManager.m_audioSource.PlayOneShot(miAudioManager.sonidoMonea);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SuenaBoton(){
        
    }
    public void InicioStart(){
        SceneManager.LoadScene("jueguito");
    }

    public void MuestraSettings(){
        panelSettings.SetActive(true);
    }

    public void SalirJuego(){
        Application.Quit();
    }

}
