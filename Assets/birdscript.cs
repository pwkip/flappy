using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class birdscript : MonoBehaviour
{

    public Rigidbody2D myRigidbody2D;
    public float flapStrength;
    public uiscript uiScript;

    InputAction jumpAction;

    public bool birdIsAlive = true;

    // Start is called before the first frame update
    void Start() {

        uiScript = GameObject.FindGameObjectWithTag("UI").GetComponent<uiscript>();

        jumpAction = InputSystem.actions.FindAction("Jump");


    }
    // Update is called once per frame
    void Update()
    {

        if (jumpAction.IsPressed() && birdIsAlive)
        {
            Jump();
        }

    }

    private void Jump()
    {

        if (birdIsAlive)
        {
            myRigidbody2D.linearVelocity = Vector2.up * flapStrength;
        }
    } 

    void OnCollisionEnter2D(Collision2D collision)
    {
        uiScript.GameOver();
        birdIsAlive = false;
    }

}
