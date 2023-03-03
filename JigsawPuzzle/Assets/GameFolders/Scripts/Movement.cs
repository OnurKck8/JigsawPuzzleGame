using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Camera _camera;
    Vector2 _startPos;
    GameObject[] _cardArray;

    GameManager _gameManager;

    void Start()
    {
        _camera = GameObject.Find("Main Camera").GetComponent<Camera>();
        _startPos = transform.position;

        _cardArray = GameObject.FindGameObjectsWithTag("Box");
        _gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

    }

    void Update()
    {
        if(Input.GetMouseButtonUp(0))
        {
            foreach(GameObject card in _cardArray)
            {
                if(card.name == gameObject.name)
                {
                    float _distance = Vector3.Distance(card.transform.position, transform.position);

                    if (_distance<=0.5f)
                    {
                        transform.position = card.transform.position;
                        _gameManager.IncreaseNumber();
                        this.enabled=false;
                    }

                    else
                    {
                        transform.position = _startPos;
                    }
                }
            }
        }
    }

    private void OnMouseDrag()
    {
        Vector3 _pos = _camera.ScreenToWorldPoint(Input.mousePosition);
        _pos.z = 0;
        transform.position = _pos;
    }
}
