using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScene : MonoBehaviour
{
    [SerializeField] GameObject _snake;
    [SerializeField] GameObject _slime;
    [SerializeField] GameObject _goblin;
    [SerializeField] GameObject _joystick;

    void Start()
    {
        _snake = Instantiate(_snake);
        _slime = Instantiate(_slime);
        _goblin = Instantiate(_goblin);
        _joystick = Instantiate(_joystick);

        GameObject go = new GameObject { name = "@Monster_Root" };
        _snake.transform.parent = go.transform;
        _slime.transform.parent = go.transform;
        _goblin.transform.parent = go.transform;

        _slime.AddComponent<PlayerController>();

        Camera.main.GetComponent<CameraController>()._player = _slime;
    }


    void Update()
    {

    }
}
