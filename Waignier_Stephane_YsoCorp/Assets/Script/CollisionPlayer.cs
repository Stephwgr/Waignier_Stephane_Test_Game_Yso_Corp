using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CollisionPlayer : MonoBehaviour
{
    public GameObject _respawnPoint;
    public GameObject _player;

    public int _countReset;

    public CountRing _countRing;

    public void OnTriggerEnter(Collider col)
    {
        if (col.tag == "BlockDead")
        {
            //Debug.Log("trigger");

            //_player.transform.position = _respawnPoint.transform.position;

            //_countRing.AddRing(0);
            //_countRing._ringCount = _countReset;
            //_countRing.Txt_ScoreRing.text = _countReset.ToString();


            SceneManager.LoadScene("Main_Scene");


        }
    }

   

    



}
