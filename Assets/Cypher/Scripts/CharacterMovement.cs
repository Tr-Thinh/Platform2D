using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 5f; // T?c ?? di chuy?n
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixUpdate()
    {
        // L?y th�ng tin t? Virtual Joystick (ho?c c�c n�t ?i?u khi?n tr�n m�n h�nh)
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // T�nh to�n vector di chuy?n
        Vector2 movement = new Vector2(moveHorizontal, moveVertical) * moveSpeed;

        // �p d?ng l?c ?? di chuy?n nh�n v?t
        rb.velocity = movement;
    }
}
