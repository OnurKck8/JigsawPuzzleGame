using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    int _placedCard = 0;
    int _totalPuzzle = 16;

    void Start()
    {
        
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
        }
    }
}
