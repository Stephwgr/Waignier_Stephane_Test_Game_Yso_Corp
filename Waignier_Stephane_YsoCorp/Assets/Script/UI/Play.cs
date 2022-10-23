using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Play : MonoBehaviour
{
    [Header("Scripts")]
    public CharacterMove _charactereMove;
    public Character_Input _charactereInput;

    [Header("UI")]
    public GameObject _pannelPlay;


    private void Awake()
    {
        Time.timeScale = 0;

        _charactereInput.enabled = false;
        _charactereMove.enabled = false;

        _pannelPlay.SetActive(true);
    }

    private void Start()
    {
        
    }

    private void Update()
    {
        
    }

    public void TouchPlay()
    {
        //Debug.Log("touche tactile");
        _pannelPlay.SetActive(false);
        Time.timeScale = 1;

        _charactereInput.enabled = true;
        _charactereMove.enabled = true;
    }
}
