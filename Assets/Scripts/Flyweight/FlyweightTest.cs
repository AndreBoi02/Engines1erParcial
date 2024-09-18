using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlyweightTest : MonoBehaviour
{
    public FlyweightSO dataScriptableObject;

    private Image _spriteImage;
    private Text _nameText;
    private Text _descriptionText;

    private void Awake()
    {
        _spriteImage = transform.Find("Sprite").GetComponent<Image>();
        _nameText = transform.Find("NameText").GetComponent<Text>();
        _descriptionText = transform.Find("DescriptionText").GetComponent<Text>();

        _spriteImage.sprite = dataScriptableObject.sprite;
        _nameText.text = dataScriptableObject.name;
        _descriptionText.text = dataScriptableObject.description;
    }
}
