using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.Layouts;

public static class Controls

{
    public static PlayerControls controls;
    
    
    
    public static void Initialize(Player e)
    {
        controls = new PlayerControls();
        controls.WorldControls.Movement.performed += ctx => e.SetDirection(ctx.ReadValue<Vector2>());
        controls.WorldControls.Jump.performed += ctx => e.Jump();
        controls.WorldControls.Consume.performed += ctx => e.Consume();
        controls.WorldControls.PickUpObject.performed += ctx => e.PickUp();
        controls.WorldControls.ScorpionsTail.performed += ctx => e.TailJab();

        controls.CasinoControls.SelectCard.performed += ctx => e.SelectCard();
        controls.CasinoControls.RollDice.performed += ctx => e.RollDice();
        controls.CasinoControls.SpinSlots.performed += ctx => e.SpinSlots();

        controls.UIControls.Select.performed += ctx => e.UISetup();
    }

    public static void SetWorldControls()
    {
        controls.WorldControls.Enable();
        controls.CasinoControls.Disable();
        controls.UIControls.Disable();
    }

    public static void SetCasinoControls()
    {
        controls.WorldControls.Disable();
        controls.CasinoControls.Enable();
        controls.UIControls.Disable();
    }

    public static void SetUIControls()
    {
        controls.WorldControls.Disable();
        controls.CasinoControls.Disable();
        controls.UIControls.Enable();
    }
}
