using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanteSprayBullet : MonoBehaviour
{
    public Transform spraySpawnPoint;
    public GameObject sprayPrebab;

    public float _speedSpray;
    public float _timeBtwShots;
    public float _timeValue;

    public bool isShooting;



    private void Start()
    {
        isShooting = false;
    }

    public void InstanceSpray()
    {   
        if (!isShooting)
        {
            StartCoroutine(TimerBtwShot());

        }

    }

    IEnumerator TimerBtwShot()
    {
        isShooting = true;

        var spray = Instantiate(sprayPrebab, spraySpawnPoint.position, spraySpawnPoint.rotation);
        spray.GetComponent<Rigidbody>().velocity = spraySpawnPoint.forward * _speedSpray;

        Debug.Log("Courutine commence");
        yield return new WaitForSeconds(_timeBtwShots);
        Debug.Log("Courutine fini");

        isShooting = false;



    }
}
