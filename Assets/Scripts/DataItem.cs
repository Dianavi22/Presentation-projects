using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class DataItem : MonoBehaviour
{
    public string title;
    public string authors;
    public string gender;
    public string linkBuildPlace;
    public string description;
    public string linkItch;
    public string devTime;
    public Sprite sprite;
    public Sprite itemSprite;

    private SetCard _setCard;
    [SerializeField] TMP_Text _title;
    [SerializeField] Image _cover;
    [SerializeField] GameObject _cadreItem; 


    private void Start()
    {
        _cadreItem.SetActive(true);
        _setCard = FindObjectOfType<SetCard>();
        _cover.sprite = itemSprite;
        _title.text = title;
    }
    public void SetCardInformation()
    {
        _setCard.linkBuild = linkBuildPlace;
        _setCard.titlePlace.text = title;
        _setCard.authorsPlace.text = authors;
        _setCard.genderPlace.text = gender;
        _setCard.devTimePlace.text = devTime;
        _setCard.descriptionPlace.text = description;
        _setCard.linkItchPlace.text = linkItch;
        _setCard.imagePlace.sprite = sprite;
        _setCard.ClickItem();
    }
}
