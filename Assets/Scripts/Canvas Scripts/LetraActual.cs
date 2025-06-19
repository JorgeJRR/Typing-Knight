using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LetraActual : MonoBehaviour
{

    public TextMeshProUGUI texto;
    public Movement movement;

    public char letra;

    void Start()
    {
        texto = GetComponent<TextMeshProUGUI>();
        movement = FindObjectOfType<Movement>();
    }

    public void UpdateVisual(string letter)
    {
        texto.text = letter;
    }
}
