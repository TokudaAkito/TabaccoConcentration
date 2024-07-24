using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;

public class TurnCards : MonoBehaviour
{
    private GameObject _clickedObject;
    private SpriteRenderer _sprite;
    void Start()
    {

    }
    void Update()
    {
        ClickCard();
    }

    void ClickCard()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray =Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction);
            if (hit)
            {
                _clickedObject = hit.collider.gameObject;
                _sprite = _clickedObject.GetComponent<SpriteRenderer>();
                _sprite.sortingOrder =  2 - _sprite.sortingOrder;
            }
        }
    }
}
