using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private int MouseClickedAmount = 0;
    [SerializeField] private float _ballSpeed;
    private Vector3 _moveDir;

    private Boolean isGrounded;
    private Rigidbody rb;
    private float depth;

    // Start is called before the first frame update
    void Start()
    {
        InputActions.Init(this);

        rb = GetComponent<Rigidbody>();
        depth = GetComponent<Collider>().bounds.size.y;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.rotation * (_ballSpeed * Time.deltaTime * _moveDir);

        if (!CheckGround())
        {
            rb.useGravity = true;
        }

    }


    public void MouseWasClicked()
    {
        MouseClickedAmount++;

        if(MouseClickedAmount == 1)
        {
            _moveDir = new Vector3(1, 0, 0);
        }

        if(MouseClickedAmount % 2 == 0)
        {
            _moveDir = new Vector3(0, 0, 1);

        }
        else
        {
            _moveDir = new Vector3(1, 0, 0);
        }


    }


    private void StartMovement()
    {

    }



    private bool CheckGround()
    {
        isGrounded = Physics.Raycast(transform.position, Vector3.down, depth);

        Debug.DrawRay(transform.position, Vector3.down * depth, Color.red, 0, false);

        return isGrounded;
    }
}
