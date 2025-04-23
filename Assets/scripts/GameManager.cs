using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static bool Mortaja = false;

    public static int puntos = 1;

    public static int vidas = 3;

    public static int muertes = 0;

    GameOverScript gameoverScreen;

    GameObject vidasText;
    GameObject puntosText;

    // Start is called before the first frame update
    void Start()
    {
        vidasText = GameObject.Find("vidasText");

    }

    // Update is called once per frame
    void Update()
    {
        vidasText.GetComponent<TextMeshProUGUI>().text = vidas.ToString();

    }

    
}
