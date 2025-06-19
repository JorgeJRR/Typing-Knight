using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using static UnityEditor.Timeline.TimelinePlaybackControls;

public class Movement : MonoBehaviour
{
    [Header("Movimiento")]
    public Rigidbody2D rb;
    [SerializeField]
    private float jumpForce = 8f;
    [SerializeField]
    private float groundedSpeed = -3f;
    [SerializeField]
    private float airSpeed = 2.5f;

    [Header("Estado")]
    [SerializeField]
    private Transform groundCheck;
    [SerializeField]
    private LayerMask groundLayer;
    public bool isGrounded;

    [Header("Lógica de Letras")]
    private char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
    public char currentLetter;

    private float currentSpeed;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        GenerateRandomLetter();
    }

    void OnEnable()
    {
        Keyboard.current.onTextInput += GetKeyInput;
    }
    void OnDisable()
    {
        Keyboard.current.onTextInput -= GetKeyInput;
    }

    private void GetKeyInput(char obj)
    {
        if (obj == currentLetter && isGrounded)
        {
            rb.velocity = Vector2.up * jumpForce;
            isGrounded = false;
            GenerateRandomLetter();
        }
    }

    private void GenerateRandomLetter()
    {
        currentLetter = alphabet[Random.Range(0, alphabet.Length)];
        Debug.Log($"Letra nueva: {currentLetter}");
        GameManager.Instance.UpdateLetterVisual(currentLetter);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Fireball")
        {
            GameManager.Instance.gameOver = true;
        }
        if (collision.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }
    }
}