using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Points : MonoBehaviour
{
    private int points;
    private int points_Lab2;
    private int points_Lab3;

    [SerializeField] private TextMeshProUGUI Numkeys;
    [SerializeField] private TextMeshProUGUI Numkeys2;
    [SerializeField] private TextMeshProUGUI Numkeys3;


    public void SumPoints(int newPoints)
    {
        points += newPoints;
        Numkeys.text= points.ToString();
    }

    public void SumPointsLab2(int newPoints)
    {
        points_Lab2 += newPoints;
        Numkeys2.text = points_Lab2.ToString();
    }

    public void SumPointsLab3(int newPoints)
    {
        points_Lab3 += newPoints;
        Numkeys3.text = points_Lab2.ToString();
    }

    public int GetSetpoints { get => points; set => points = value; }
    public int GetSetpoints_Lab2 { get => points_Lab2; set => points_Lab2 = value; }
    public int GetSetpoints_Lab3 { get => points_Lab3; set => points_Lab3 = value; }
}
