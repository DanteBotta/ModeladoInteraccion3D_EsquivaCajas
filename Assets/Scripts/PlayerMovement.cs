using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    int Posicion = 2;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            if (Posicion < 3)
            {
                transform.Translate(2f, 0, 0);
                Posicion += 1;
            }
            
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
        {
            if (Posicion > 1)
            {
                transform.Translate(-2f, 0, 0);
                Posicion -= 1;
            }
            
        }
    }
}
