using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    [SerializeField] private GameObject collectEffect;
    [SerializeField] private Points points;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Jugador"))
        {
            Instantiate(collectEffect, transform.position, Quaternion.identity);
            points.SumPoints(1);
            Destroy(gameObject);
        }
        else if (other.gameObject.CompareTag("Jugador_2"))
        {
            Instantiate(collectEffect, transform.position, Quaternion.identity);
            points.SumPointsLab2(1);
            Destroy(gameObject);
        }

        else if (other.gameObject.CompareTag("Jugador_3"))
        {
            Instantiate(collectEffect, transform.position, Quaternion.identity);
            points.SumPointsLab3(1);
            Destroy(gameObject);
        }
    }
}
