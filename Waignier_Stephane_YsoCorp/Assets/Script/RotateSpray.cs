using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSpray : MonoBehaviour
{
    public int _speed;
    [SerializeField] Vector3 _rotation;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(_rotation * _speed * Time.deltaTime);


    }
}
