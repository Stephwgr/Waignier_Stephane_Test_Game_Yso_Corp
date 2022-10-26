using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;



public class CountRing1 : MonoBehaviour
{
    public int _ringCount;
    public int _ringFinishLevel;

    public TextMeshProUGUI Txt_ScoreRing;
    public TextMeshProUGUI Txt_ScoreRingFinish;

    [Header("Panel")]
    public GameObject _panelVictoire;



    private void Start()
    {
        Txt_ScoreRingFinish.text = _ringFinishLevel.ToString();
        _panelVictoire.SetActive(false);
    }

    public void AddRing(int count)
    {
        _ringCount += count;
        Txt_ScoreRing.text = _ringCount.ToString();

        if (_ringCount == _ringFinishLevel)
        {
            Time.timeScale = 0;

            _panelVictoire.SetActive(true);

        }
    }

    public void Quit()
    {
        //SceneManager.LoadScene("");
        Debug.Log("Quitter");
        Application.Quit();
    }


}
