using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public int _placedCard = 0;
    int _totalPuzzle = 12;

    public GameObject _gamePanel;

    void Start()
    {
        _gamePanel.SetActive(false);
    }

    
    void Update()
    {
        
    }

    public void IncreaseNumber()
    {
        _placedCard++;

        if(_placedCard==_totalPuzzle)
        {
            Debug.Log("sonraki bölüm geç");
            _gamePanel.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
