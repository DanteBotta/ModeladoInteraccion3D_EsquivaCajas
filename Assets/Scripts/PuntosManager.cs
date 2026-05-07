using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PuntosManager : MonoBehaviour
{
    public TextMeshProUGUI TextoPuntos;
    float Puntos = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Puntos += 0.025f;
        TextoPuntos.text = "Puntos: " + Puntos.ToString("F0");
    }
}
