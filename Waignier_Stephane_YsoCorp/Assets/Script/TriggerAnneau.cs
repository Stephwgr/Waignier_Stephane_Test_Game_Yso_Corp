using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;




public class TriggerAnneau : MonoBehaviour
{
    public CountRing _countRing;

    public CollisionPlayer _colPlayer;

    public ListRing _listRing;

    public bool _resetRing = true;

   

    public void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Spray")
        {
            _countRing.AddRing(1);
            //Debug.Log("trigger");
            //this.gameObject.SetActive(false);

            //_resetRing = false;

            //if (_resetRing == false)
            //{
            //    _listRing.listRing.Add(this.gameObject);
            //}



        }
    }

    

    public void Update()
    {
        ResetRing();
    }



    public void ResetRing()
    {
        if (_colPlayer._player.transform.position == _colPlayer._respawnPoint.transform.position)
        {
            this.gameObject.SetActive(true);
        }
    }


}
