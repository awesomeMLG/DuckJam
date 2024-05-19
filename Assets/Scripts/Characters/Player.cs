using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : Character
{
    [SerializeField] public float speed;
    
    [SerializeField] private float jumpForce;
    
    // Start is called before the first frame update
    void Start()
    {
        Controls.Initialize(this);
        Controls.SetUIControls();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    
    private void Move()
    {
        if (isGrounded)
        {
            playerPhysics.AddForce(axisMove.x * speed * Vector2.right);
        }
    }

    public void Jump()
    {
        CheckGround();
        if (!isGrounded) return;
        playerPhysics.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }

    public void Consume()
    {
        
    }

    public void PickUp()
    {
        
    }

    public void TailJab()
    {
        
    }

    public void SelectCard()
    {
        
    }

    public void RollDice()
    {
        
    }

    public void SpinSlots()
    {
        
    }

    public void UISetup()
    {
        if (Controls.controls.UIControls.enabled) return;
        
        if (!Controls.controls.UIControls.enabled)
        {
            
        }
    }
}
