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
        // L?y thông tin t? Virtual Joystick (ho?c các nút ?i?u khi?n trên màn hình)
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Tính toán vector di chuy?n
        Vector2 movement = new Vector2(moveHorizontal, moveVertical) * moveSpeed;

        // Áp d?ng l?c ?? di chuy?n nhân v?t
        rb.velocity = movement;
    }
}
