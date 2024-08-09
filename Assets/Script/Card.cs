using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour
{
    private Image _image;
    [SerializeField] public static int _id;
    [SerializeField] private Sprite[] _cardImage;

    private void Start()
    {
        _image = GetComponent<Image>();
        _image.sprite = _cardImage[_id];
    }
}
