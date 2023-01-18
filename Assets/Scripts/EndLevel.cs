using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLevel : MonoBehaviour
{
    [SerializeField] private Points points;
    [SerializeField] private UIController uiController;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Jugador"))
        {
            if(points.GetSetpoints == 1)
            {
                uiController.ActivateFelicitacion();
            }
            else
            {
                SSTools.ShowMessage("¡Te falta una llave!", SSTools.Position.bottom, SSTools.Time.twoSecond);
            }
        }

        if (other.gameObject.CompareTag("Jugador_2"))
        {
            if (points.GetSetpoints_Lab2 == 1)
            {
                uiController.ActivateFelicitacion();
            }
            else
            {
                SSTools.ShowMessage("¡Te falta una llave!", SSTools.Position.bottom, SSTools.Time.twoSecond);
            }
        }

        if (other.gameObject.CompareTag("Jugador_3"))
        {
            if (points.GetSetpoints_Lab2 == 1)
            {
                uiController.ActivateFelicitacion();
            }
            else
            {
                SSTools.ShowMessage("¡Te falta una llave!", SSTools.Position.bottom, SSTools.Time.twoSecond);
            }
        }
    }
}
