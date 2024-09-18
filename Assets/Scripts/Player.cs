using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float Jumpforce;
    Rigidbody2D rb;
    GameController gameController;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        gameController=FindObjectOfType<GameController>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * Jumpforce);
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Obstacle"))
        {
            gameController.SetGameOverState(true);
            Debug.Log("touch");
        }
    }

}
