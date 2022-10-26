using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class TriggerAnneau : MonoBehaviour
{
    public CountRing _counRing;

    public void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Spray");
        {
            _counRing.AddRing(1);
            //Debug.Log("trigger");

        }
    }


}
