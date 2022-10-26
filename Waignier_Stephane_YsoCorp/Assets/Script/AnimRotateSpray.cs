using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimRotateSpray : MonoBehaviour
{
    public float _speed;
    public Vector3 _rotateSpray;

    private void Update()
    {
        transform.Rotate(_rotateSpray * _speed * Time.deltaTime);
    }



}
