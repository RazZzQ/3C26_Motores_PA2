using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerActions : MonoBehaviour
{
    public Rigidbody2D rb2D;
    public float velocityModifier = 5;
    private Vector2 _distance;
    float direccion;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void PlayerMovement(InputAction.CallbackContext callbackContext)
    {
        float Movimiento = callbackContext.ReadValue<float>();
        Debug.Log(Movimiento);
        direccion = Movimiento * velocityModifier;

        rb2D.velocity = new Vector2(0,direccion);
    }
}
