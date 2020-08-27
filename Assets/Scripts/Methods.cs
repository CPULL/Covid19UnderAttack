using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Methods : MonoBehaviour
{
    public GameObject mainUpgradesTab;
    public GameObject changeLocationTab;
    public GameObject premiumShopTab;
    public GameObject prestigeTab;

    public GameObject labClickUpgradesTab;
    public GameObject labProductionUpgradesTab;
    public GameObject prestigeUpgradesTab;

    public GameObject mainIcons;

    private void Awake()
    {
        DisableTabs();
        mainIcons.gameObject.SetActive(true);
    }
    public void ChangeTabs(string name)
    {
        DisableTabs();
        switch (name)
        {
            case "mainUpgradesTab":
                {
                    labClickUpgradesTab.gameObject.SetActive(true);
                    mainUpgradesTab.gameObject.SetActive(true);

                    mainIcons.SetActive(false);
                    break;
                }

            case "labClickUpgradesTab":
                {
                    mainUpgradesTab.gameObject.SetActive(true);
                    labClickUpgradesTab.gameObject.SetActive(true);

                    mainIcons.SetActive(false);
                    break;
                }
            case "labProductionUpgradesTab":
                {
                    mainUpgradesTab.gameObject.SetActive(true);
                    labProductionUpgradesTab.gameObject.SetActive(true);

                    mainIcons.SetActive(false);
                    break;
                }

            case "labPrestigeUpgradesTab":
                {
                    mainUpgradesTab.gameObject.SetActive(true);
                    prestigeUpgradesTab.gameObject.SetActive(true);

                    mainIcons.SetActive(false);
                    break;
                }

            case "changeLocationTab":
                {
                    changeLocationTab.gameObject.SetActive(true);
                    break;
                }
            case "premiumShopTab":
                {
                    premiumShopTab.gameObject.SetActive(true);
                    break;
                }     
            case "prestigeTab":
                {
                    prestigeTab.gameObject.SetActive(true);
                    break;
                }

          
        }
    }

    public void DisableTabs()
    {
        changeLocationTab.gameObject.SetActive(false);
        premiumShopTab.gameObject.SetActive(false);

        mainUpgradesTab.gameObject.SetActive(false);
        labClickUpgradesTab.gameObject.SetActive(false);
        labProductionUpgradesTab.gameObject.SetActive(false);
        prestigeUpgradesTab.gameObject.SetActive(false);
        prestigeTab.gameObject.SetActive(false);

        mainIcons.gameObject.SetActive(false);
    }

    public void GoBackToMainLab()
    {
        DisableTabs();
        mainIcons.gameObject.SetActive(true);
    }
}
