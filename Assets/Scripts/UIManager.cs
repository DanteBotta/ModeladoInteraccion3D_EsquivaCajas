using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI TextoTiempo;
    float Tiempo = 0f;
    public bool JuegoCorriendo = true;

    // Update is called once per frame
    void Update()
    {
        if (JuegoCorriendo == true)
        {
            Tiempo += Time.deltaTime;
            TextoTiempo.text = "Tiempo: " + Tiempo.ToString("F2") + "s";
        }
    }
}
