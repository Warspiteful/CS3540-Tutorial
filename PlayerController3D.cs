using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController3D : MonoBehaviour
{


    private PlayerControls _controls;

    private Vector2 movement;

    // Start is called before the first frame update
    void Start()
    {
        _controls = new PlayerControls();
        _controls.Gameplay.Enable();

        _controls.Gameplay.Movement.started += HandleMovement;
        _controls.Gameplay.Movement.canceled += HandleMovement;
    }

    private void HandleMovement(InputAction.CallbackContext ctx)
    {
        movement = ctx.ReadValue<Vector2>();
    }
    
    void Update()
    {
        transform.Translate(new Vector3(movement.x,0,movement.y) *10 * Time.deltaTime);
    }
}