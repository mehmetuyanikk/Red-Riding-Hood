using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class PlayerControllerK : MonoBehaviour
{

    [SerializeField] GameObject _player;

    [SerializeField] float _jumpSpeed = 300f;
    [SerializeField] bool _jumpActive;

    MoveCompenentK _moveComponent;
    Rigidbody2D _rigidBody;

    private void Awake()
    {
        _moveComponent = new MoveCompenentK();

        _rigidBody.GetComponentInChildren<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _jumpActive = true;
        }
    }

    private void FixedUpdate()
    {
        if (_jumpActive)
        {
            _moveComponent.JumpAxis(_rigidBody, _jumpSpeed, true);

        }

        _jumpActive = false;

    }

}
