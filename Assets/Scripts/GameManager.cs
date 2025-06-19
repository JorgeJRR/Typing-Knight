using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    [Header("Scene Game Objects")]
    public GameObject gameOverScreen;
    public GameObject _fireParent;
    public Movement playerMS;
    public EnemyScript enemy;
    public PuntuacionScript points;

    public LetraActual LetterVisual;

    public bool gameOver;

    private void Awake()
    {
        Instance = this;
        gameOver = false;
    }

    private void Start()
    {
        gameOverScreen.SetActive(false);
        playerMS.enabled = true;
        _fireParent.SetActive(true);
    }

    public void GameOver()
    {
        gameOverScreen.SetActive(true);
        playerMS.enabled = false;
        _fireParent.SetActive(false);
    }

    public void UpdateLetterVisual(char currentLetter)
    {
        string visualLetter = currentLetter.ToString();
        LetterVisual.UpdateVisual(visualLetter);
    }
}
