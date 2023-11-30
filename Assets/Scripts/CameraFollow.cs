using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private BallController myPlayer;

    private Camera myCamera;

    public void FixedUpdate()
    {
        if(myPlayer.CheckGround())
        {
            


        }



    }

}
