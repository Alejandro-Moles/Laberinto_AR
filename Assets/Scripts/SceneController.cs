using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    [SerializeField] private GameObject Panel_Ayuda;
    [SerializeField] private GameObject Panel_Inicio;

    public void PlayButton()
    {
        SceneManager.LoadScene("Game_Scene");
    }


    public void HelpButton()
    {
        Panel_Ayuda.SetActive(true);
        Panel_Inicio.SetActive(false);
    }

    public void StartButton()
    {
        Panel_Ayuda.SetActive(false);
        Panel_Inicio.SetActive(true);
    }
}
