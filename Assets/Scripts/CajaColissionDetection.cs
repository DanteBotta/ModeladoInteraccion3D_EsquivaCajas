using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajaColissionDetection : MonoBehaviour
{
    public CajaMovement CajaMovementScript;

    void Start()
    {
        CajaMovementScript = GetComponent<CajaMovement>();
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Suelo"))
        {
            CajaMovementScript.MoveBoxToRandomPosition();
        }
    }
}
