using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerJoystick : MonoBehaviour
{
    // Start is called before the first frame update
    public float Speed;
    private Rigidbody2D rigidbody2d;
    [SerializeField] private Joystick joystick;
    void Start()
    {
        rigidbody2d = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        _Mover();
    }

    void _Mover()
    {
        
    }
}
