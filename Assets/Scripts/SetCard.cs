using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SetCard : MonoBehaviour
{
    [SerializeField] LauncherManager _launcherManager;

    public TMP_Text titlePlace;
    public TMP_Text authorsPlace;
    public TMP_Text genderPlace;
    public TMP_Text descriptionPlace;
    public TMP_Text linkItchPlace;
    public TMP_Text devTimePlace;
    public Image imagePlace;

    [SerializeField] GameObject _card;
    [SerializeField] GameObject _bloomBlue;
    [SerializeField] GameObject _bloomPurple;
    public string linkBuild;

    public void ClickItem()
    {
        _card.SetActive(true);
        _bloomBlue.SetActive(false);
        _bloomPurple.SetActive(true);
    }

    public void CloseCard()
    {
        _card.SetActive(false);
        _bloomPurple.SetActive(false);
        _bloomBlue.SetActive(true);

    }

    public void SetLink()
    {
        Application.OpenURL(linkItchPlace.text);
    }

    public void LaunchGame()
    {
        _launcherManager.LaunchBuild(linkBuild);
    }
}
