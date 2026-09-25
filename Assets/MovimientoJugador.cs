using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D))]
public class MovimientoJugador : MonoBehaviour
{
    public float velocidad = 5f;

    private Rigidbody2D rb;
    private Vector2 movimiento;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0f;
        rb.freezeRotation = true;
    }

    void Update()
    {
        Keyboard teclado = Keyboard.current;

        if (teclado == null)
        {
            movimiento = Vector2.zero;
            return;
        }

        float horizontal = 0f;
        float vertical = 0f;

        if (teclado.aKey.isPressed || teclado.leftArrowKey.isPressed) horizontal = -1f;
        if (teclado.dKey.isPressed || teclado.rightArrowKey.isPressed) horizontal = 1f;
        if (teclado.sKey.isPressed || teclado.downArrowKey.isPressed) vertical = -1f;
        if (teclado.wKey.isPressed || teclado.upArrowKey.isPressed) vertical = 1f;

        movimiento = new Vector2(horizontal, vertical).normalized;
    }

    void FixedUpdate()
    {
        rb.linearVelocity = movimiento * velocidad;
    }
}