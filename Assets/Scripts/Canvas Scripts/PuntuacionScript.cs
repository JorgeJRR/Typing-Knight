using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class PuntuacionScript : MonoBehaviour
{
    public TextMeshProUGUI texto;
    public int points;

    public void Start()
    {
        points = 0;
        StartCoroutine(StartGetPoints());
    }

    IEnumerator StartGetPoints()
    {
        while(GameManager.Instance.gameOver == false)
        {
            points++;
            texto.text = points.ToString();
            yield return new WaitForSeconds(0.5f);
        }
    }
}
