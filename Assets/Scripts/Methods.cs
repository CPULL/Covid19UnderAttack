using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Methods : MonoBehaviour
{
    public GameObject mainUpgradesTab;
    public GameObject changeLocationTab;
    public GameObject premiumShopTab;

    public GameObject labClickUpgradesTab;
    public GameObject labProductionUpgradesTab;


    public void ChangeTabs(string name)
    {
        DisableTabs();
        switch (name)
        {
            case "mainUpgradesTab":
                {
                    labClickUpgradesTab.gameObject.SetActive(true);
                    mainUpgradesTab.gameObject.SetActive(true);
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

            case "labClickUpgradesTab":
                {
                    mainUpgradesTab.gameObject.SetActive(true);
                    labClickUpgradesTab.gameObject.SetActive(true);
                    break;
                }   
            case "labProductionUpgradesTab":
                {
                    mainUpgradesTab.gameObject.SetActive(true);
                    labProductionUpgradesTab.gameObject.SetActive(true);
                    break;
                }
        }
    }

    public void DisableTabs()
    {
        mainUpgradesTab.gameObject.SetActive(false);
        changeLocationTab.gameObject.SetActive(false);
        premiumShopTab.gameObject.SetActive(false);

        labClickUpgradesTab.gameObject.SetActive(false);
        labProductionUpgradesTab.gameObject.SetActive(false);
    }
}
