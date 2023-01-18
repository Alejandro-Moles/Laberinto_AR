using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class UIController : MonoBehaviour
{
    [SerializeField] private GameObject PanelLaberinto_1;
    [SerializeField] private GameObject PanelLaberinto_2;
    [SerializeField] private GameObject PanelLaberinto_3;

    public void ActivateLaberinto1()
    {
        PanelLaberinto_1.SetActive(true);
    }

    public void DesactivateLaberinto1()
    {
        PanelLaberinto_1.SetActive(false);
    }

    public void ActivateFelicitacion()
    {
        SceneManager.LoadScene("Felicitacion_Scene");
    }

    public void DesactivateFelicitacion()
    {
        SceneManager.LoadScene("Game_Scene");
    }


    public void irInicio()
    {
        SceneManager.LoadScene("Start_Scene");
    }

    public void ActivateLaberinto2()
    {
        PanelLaberinto_2.SetActive(true);
    }

    public void DesactivateLaberinto2()
    {
        PanelLaberinto_2.SetActive(false);
    }

    public void ActivateLaberinto3()
    {
        PanelLaberinto_3.SetActive(true);
    }

    public void DesactivateLaberinto3()
    {
        PanelLaberinto_3.SetActive(false);
    }

}
