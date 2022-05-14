using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCompenentK : IKirmiziBKiz
{
    public float Jump => Input.GetAxis("Jump");

    public void JumpAxis(Rigidbody2D _rigidBody, float _jumpSpeed, bool _jumpActive)
    {
        switch (_jumpActive)
        {
            case true:
                _rigidBody.AddForce(Vector2.up * _jumpSpeed);
                break;

            default:
                _jumpActive = false;
                break;
        }
    }
    
}
