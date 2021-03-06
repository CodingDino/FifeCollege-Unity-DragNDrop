﻿// -----------------------------------------------------------------------------
#region File Info - QuitAction.cs
// -----------------------------------------------------------------------------
// Project:     Dino Unity Toolkit
// Created:     Sarah Herzog 2019
// Purpose:     Quits the application
// -----------------------------------------------------------------------------
#endregion
// -----------------------------------------------------------------------------


// -----------------------------------------------------------------------------
#region Libraries
// -----------------------------------------------------------------------------
using UnityEngine;
// -----------------------------------------------------------------------------
#endregion
// -----------------------------------------------------------------------------


// -----------------------------------------------------------------------------
#region Component: UITextAction
// -----------------------------------------------------------------------------
[AddComponentMenu("Dino Toolkit/Actions/QuitAction")]
[HelpURL("https://github.com/CodingDino/FifeCollege-Unity-DragNDrop/wiki/QuitAction")]
public class QuitAction : MonoBehaviour
{

    // -------------------------------------------------------------------------
    #region Action Functions
    // -------------------------------------------------------------------------
    public void ActionQuit()
    {
        Application.Quit();
    }
    // -------------------------------------------------------------------------
    #endregion
    // -------------------------------------------------------------------------


}
// -----------------------------------------------------------------------------
#endregion
// -----------------------------------------------------------------------------