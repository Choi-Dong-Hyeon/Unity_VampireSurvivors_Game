using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   public Vector2 _moveDir;
    float _speed = 5f;

    void Start()
    {

    }

    void Update()
    {
       // UpdateInput();
        MovePlayer();
    }

    void UpdateInput()
    {
        Vector2 moveDir = Vector2.zero;

        if (Input.GetKey(KeyCode.W))
            moveDir.y += 1;
        if (Input.GetKey(KeyCode.S))
            moveDir.y -= 1;
        if (Input.GetKey(KeyCode.A))
            moveDir.x -= 1;
        if (Input.GetKey(KeyCode.D))
            moveDir.x += 1;


        _moveDir = moveDir.normalized;
    }

    void MovePlayer()
    {
        Vector3 dir = _moveDir * _speed * Time.deltaTime;
        transform.position += dir;
    }

}
