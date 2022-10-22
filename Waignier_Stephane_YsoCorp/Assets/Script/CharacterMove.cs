using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    private Vector3 _direction;
    public GameObject _player;


    private void Start()
    {
        _player = GetComponent<GameObject>();
    }
    private void FixedUpdate()
    {
       
    }

}
