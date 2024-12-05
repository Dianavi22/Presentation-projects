using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Progress;

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
    public string linkBuild;

    public void ClickItem()
    {
        _card.SetActive(true);
    }

    public void CloseCard()
    {
        _card.SetActive(false);
    }

    private void SetLink()
    {
        Application.OpenURL(linkItchPlace.text);
    }

    public void LaunchGame()
    {
        _launcherManager.pathToOtherBuild = linkBuild;
        _launcherManager.LaunchBuild();
    }
}
