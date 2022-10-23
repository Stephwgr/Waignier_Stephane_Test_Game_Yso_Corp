using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrailMeshEffect : MonoBehaviour
{
    public float _timeActivate = 2f;
    public float meshRefreshRate = 0.1f;
    public Transform _posSpawn;

    public float meshDestroyDelay = 1f;

    public Material color;

    private bool isTrailActive;
    private SkinnedMeshRenderer[] _skinnedMeshRenderers;


    void Start()
    {
        
    }

    
    public void Update()
    {
        //AfterImage();
    }

    public void AfterImage()
    {
        isTrailActive = true;
        StartCoroutine(TrailActivate(_timeActivate));

        if (Input.GetKeyDown(KeyCode.Space))
        {


        }
    }

    IEnumerator TrailActivate(float _timeActive)
    {
        while (_timeActive > 0)
        {
            _timeActive -= meshRefreshRate;

            if (_skinnedMeshRenderers == null)
            {
                _skinnedMeshRenderers = GetComponentsInChildren<SkinnedMeshRenderer>();

            }

            for (int i = 0; i < _skinnedMeshRenderers.Length; i++)
            {
                GameObject _gameObj = new GameObject();
                _gameObj.transform.SetPositionAndRotation(_posSpawn.position, _posSpawn.rotation);

                MeshRenderer _mr = _gameObj.AddComponent<MeshRenderer>();
               MeshFilter _mf = _gameObj.AddComponent<MeshFilter>();
                
               Mesh mesh = new Mesh();
                _skinnedMeshRenderers[i].BakeMesh(mesh);

                _mf.mesh = mesh;
                _mr.material = color;

                Destroy(_gameObj, meshDestroyDelay);                     
                
            }


            yield return new WaitForSeconds(meshRefreshRate);
        }

        isTrailActive = false;
    }

}
