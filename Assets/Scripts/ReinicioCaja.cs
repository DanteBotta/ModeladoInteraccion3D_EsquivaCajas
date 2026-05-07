using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReinicioCaja : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        int NuevaPosicion = Random.range(0, 3)
        if (col.gameObject.CompareTag("Suelo"))
        {
            transform.Translate(0, 9, 0);
        }
    }
}
