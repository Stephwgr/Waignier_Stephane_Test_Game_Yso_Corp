using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Input : MonoBehaviour
{
    public GameObject _player;

    public Vector2 _startPos;
    public Vector2 _endPos;

    private void Start()
    {
        
    }

    private void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            _startPos = Input.GetTouch(0).position;
        }



        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            _endPos = Input.GetTouch(0).position;

            if (_endPos.x < _startPos.x)
            {
                Left();
            }

            if (_endPos.x > _startPos.x)
            {
                Right();
            }
        }
    }

    public void Left()
    {
        _player.transform.position = new Vector3(_player.transform.position.x - 1, _player.transform.position.y, _player.transform.position.z);
    }

    public void Right()
    {
        _player.transform.position = new Vector3(_player.transform.position.x + 1, _player.transform.position.y, _player.transform.position.z);
    }


}
