using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class InputActions
{
    private static Controls controls;

    public static void Init(BallController myBall)
    {
        controls = new Controls();

        controls.Game.MouseClicked.performed += ctx =>
        {
            myBall.MouseWasClicked();

        };


        controls.Enable();

    }


}
