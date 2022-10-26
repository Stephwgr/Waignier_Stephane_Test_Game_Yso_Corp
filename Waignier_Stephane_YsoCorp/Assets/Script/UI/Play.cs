using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Play : MonoBehaviour
{
    [Header("Scripts")]
    public CharacterMove _charactereMove;
    public Character_Input _charactereInput;

    [Header("UI")]
    public GameObject _pannelPlay;

    public GameObject _righterButton;
    public GameObject _lefterButton;

    public GameObject _shootButtonRight;
    public GameObject _shootButtonLeft;






    private void Awake()
    {
        

        _charactereInput.enabled = false;
        _charactereMove.enabled = false;

        _shootButtonLeft.SetActive(false);
        _shootButtonRight.SetActive(false);

        _pannelPlay.SetActive(true);
    }

    private void Start()
    {
        
    }

    private void Update()
    {
        
    }

    //public void TouchPlay()
    //{
    //    //Debug.Log("touche tactile");
    //    _pannelPlay.SetActive(false);

    //    Time.timeScale = 1;

    //    _charactereInput.enabled = true;
    //    _charactereMove.enabled = true;
    //}

    public void TouchRight()
    {
        _pannelPlay.SetActive(false);

        _righterButton.SetActive(false);
        _lefterButton.SetActive(false);


        _shootButtonRight.SetActive(true);
        _shootButtonLeft.SetActive(false);


        

        _charactereInput.enabled = true;
        _charactereMove.enabled = true;
    }
    
    public void TouchLeft()
    {
        _pannelPlay.SetActive(false);

        _lefterButton.SetActive(false);
        _righterButton.SetActive(false);

        _shootButtonRight.SetActive(false);
        _shootButtonLeft.SetActive(true);


        

        _charactereInput.enabled = true;
        _charactereMove.enabled = true;
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Main_Scene");
    }
}
