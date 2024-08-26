using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CardGenerator : MonoBehaviour
{
    [SerializeField] private Card _cardPrefab;
    [SerializeField] private RectTransform _cardGenrateParent;

    private void Start()
    {
        for (int i = 0; i < 18; i++)
        {
            Card._id = Random.Range(0, 3);
            Card card = Instantiate<Card>(this._cardPrefab, this._cardGenrateParent);
        }
    }
}
