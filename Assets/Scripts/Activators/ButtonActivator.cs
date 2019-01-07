﻿// -----------------------------------------------------------------------------
#region File Info - ButtonActivator.cs
// -----------------------------------------------------------------------------
// Project:     Drag N Drop Toolkit
// Created:     Sarah Herzog 2019
// Purpose:     Perform actions when a keyboard or gamepad button is pressed
// -----------------------------------------------------------------------------
#endregion
// -----------------------------------------------------------------------------


// -----------------------------------------------------------------------------
#region Libraries
// -----------------------------------------------------------------------------
using UnityEngine;
using UnityEngine.Events;
// -----------------------------------------------------------------------------
#endregion
// -----------------------------------------------------------------------------


// -----------------------------------------------------------------------------
#region Component: ButtonActivator
// -----------------------------------------------------------------------------
public class ButtonActivator : MonoBehaviour 
{

    // -------------------------------------------------------------------------
    #region Editor Variables
    // -------------------------------------------------------------------------
    [Tooltip("The button the player must press to activate these actions. Button must be set up in InputManager.")]
    public string button;
    [Tooltip("The action(s) to be performed.")]
    public UnityEvent actions;
    // -------------------------------------------------------------------------
    #endregion
    // -------------------------------------------------------------------------


    // -------------------------------------------------------------------------
    #region Unity Functions
    // -------------------------------------------------------------------------
    private void Update()
    {
        // Each frame, check if the button is pressed.
        if (Input.GetButton(button))
        {
            // The button is pressed, so perform the actions.
            actions.Invoke();
        }
    }
    // -------------------------------------------------------------------------
    #endregion
    // -------------------------------------------------------------------------
}
// -----------------------------------------------------------------------------
#endregion
// -----------------------------------------------------------------------------