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

    public void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Ground")
        {
            Debug.Log("test collision bullet");

            Destroy(this.gameObject);
        }
    }



}
