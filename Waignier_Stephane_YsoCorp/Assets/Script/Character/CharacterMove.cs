using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    //public float _speed;

    private Rigidbody _rb;

    private void Awake()
    {
        Time.timeScale = 1;
    }

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }


    private void Update()
    {

        Move();
    }

    private void Move()
    {
        //transform.position += new Vector3(0, 0, _speed * Time.deltaTime);
        _rb.velocity = new Vector3(0,0,15);
    }

    

    

}
