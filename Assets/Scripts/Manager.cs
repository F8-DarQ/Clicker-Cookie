using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;

public class Manager : MonoBehaviour {
    public Text ClicksTotalText;
    public Text ClicksPerSecondText;
    public Text ClickerUpgradesOwnedText;
    public Text ClickerUpgradesCostText;
    public Text GrandpaUpgradesOwnedText;
    public Text GrandpaUpgradesCostText;
    public Text ForestUpgradesOwnedText;
    public Text ForestUpgradesCostText;
    public Text BakeryUpgradesOwnedText;
    public Text BakeryUpgradesCostText;
    public Text MagicUpgradesOwnedText;
    public Text MagicUpgradesCostText;
    public Text DarkMatterUpgradesOwnedText;
    public Text DarkMatterUpgradesCostText;
    public Text MultiverseUpgradesOwnedText;
    public Text MultiverseUpgradesCostText;
    
    float TotalClicks;
    float clicksPerSecond;
    float clickerUpgradesOwned;
    public float clickerUpgradeCost;
    float grandpaUpgradesOwned;
    public float grandpaUpgradeCost;
    public float grandpaClickerPerSecond;
    float forestUpgradesOwned;
    public float forestUpgradeCost;
    public float forestClickerPerSecond;
    float bakeryUpgradesOwned;
    public float bakeryUpgradeCost;
    public float bakeryClickerPerSecond;
    float magicUpgradesOwned;
    public float magicUpgradeCost;
    public float magicClickerPerSecond;
    float darkMatterUpgradesOwned;
    public float darkMatterUpgradeCost;
    public float darkMatterClickerPerSecond;
    float multiverseUpgradesOwned;
    public float multiverseUpgradeCost;
    public float multiverseClickerPerSecond;

    public void Start() {
        InvokeRepeating("ActionPerSecond", 1.0f, 1f);
    }

    public void Update() {
        clicksPerSecond = grandpaClickerPerSecond + forestClickerPerSecond + bakeryClickerPerSecond + magicClickerPerSecond + darkMatterClickerPerSecond + multiverseClickerPerSecond;
        ClicksPerSecondText.text = clicksPerSecond.ToString("0");
    }

    public void AddClicks() {
        TotalClicks += 1+clickerUpgradesOwned;
        ClicksTotalText.text = TotalClicks.ToString("0");
    }

    public void ClickerUpgrade() {
        if(TotalClicks >= clickerUpgradeCost) {
            TotalClicks -= clickerUpgradeCost;
            ClicksTotalText.text = TotalClicks.ToString("0");

            clickerUpgradesOwned++;
            ClickerUpgradesOwnedText.text = clickerUpgradesOwned.ToString("0");

            clickerUpgradeCost *= 2;
            ClickerUpgradesCostText.text = clickerUpgradeCost.ToString("0");
        }
    }

    public void GrandpaUpgrade() {
        if(TotalClicks >= grandpaUpgradeCost) {
            TotalClicks -= grandpaUpgradeCost;
            ClicksTotalText.text = TotalClicks.ToString("0");

            grandpaUpgradesOwned++;
            GrandpaUpgradesOwnedText.text = grandpaUpgradesOwned.ToString("0");

            grandpaUpgradeCost *= 2;
            GrandpaUpgradesCostText.text = grandpaUpgradeCost.ToString("0");

            grandpaClickerPerSecond = grandpaUpgradesOwned * 1;
        }
    }

    public void ForestUpgrade() {
        if(TotalClicks >= forestUpgradeCost) {
            TotalClicks -= forestUpgradeCost;
            ClicksTotalText.text = TotalClicks.ToString("0");

            forestUpgradesOwned++;
            ForestUpgradesOwnedText.text = forestUpgradesOwned.ToString("0");

            forestUpgradeCost *= 2;
            ForestUpgradesCostText.text = forestUpgradeCost.ToString("0");

            forestClickerPerSecond = forestUpgradesOwned * 3;
        }
    }

    public void BakeryUpgrade() {
        if(TotalClicks >= bakeryUpgradeCost) {
            TotalClicks -= bakeryUpgradeCost;
            ClicksTotalText.text = TotalClicks.ToString("0");

            bakeryUpgradesOwned++;
            BakeryUpgradesOwnedText.text = bakeryUpgradesOwned.ToString("0");

            bakeryUpgradeCost *= 2;
            BakeryUpgradesCostText.text = bakeryUpgradeCost.ToString("0");

            bakeryClickerPerSecond = bakeryUpgradesOwned * 5;
        }
    }

    public void MagicUpgrade() {
        if(TotalClicks >= magicUpgradeCost) {
            TotalClicks -= magicUpgradeCost;
            ClicksTotalText.text = TotalClicks.ToString("0");

            magicUpgradesOwned++;
            MagicUpgradesOwnedText.text = magicUpgradesOwned.ToString("0");

            magicUpgradeCost *= 2;
            MagicUpgradesCostText.text = magicUpgradeCost.ToString("0");

            magicClickerPerSecond = magicUpgradesOwned * 25;
        }
    }

    public void DarkMatterUpgrade() {
        if(TotalClicks >= darkMatterUpgradeCost) {
            TotalClicks -= darkMatterUpgradeCost;
            ClicksTotalText.text = TotalClicks.ToString("0");

            darkMatterUpgradesOwned++;
            DarkMatterUpgradesOwnedText.text = darkMatterUpgradesOwned.ToString("0");

            darkMatterUpgradeCost *= 2;
            DarkMatterUpgradesCostText.text = darkMatterUpgradeCost.ToString("0");

            darkMatterClickerPerSecond = darkMatterUpgradesOwned * 100;
        }
    }

    public void MultiverseUpgrade() {
        if(TotalClicks >= multiverseUpgradeCost) {
            TotalClicks -= multiverseUpgradeCost;
            ClicksTotalText.text = TotalClicks.ToString("0");

            multiverseUpgradesOwned++;
            MultiverseUpgradesOwnedText.text = multiverseUpgradesOwned.ToString("0");

            multiverseUpgradeCost *= 2;
            MultiverseUpgradesCostText.text = multiverseUpgradeCost.ToString("0");

            multiverseClickerPerSecond = multiverseUpgradesOwned * 250;
        }
    }

    public void ActionPerSecond() {
        if(grandpaUpgradesOwned >= 1) {
            TotalClicks += grandpaClickerPerSecond;
            ClicksTotalText.text = TotalClicks.ToString("0");
        }
        if(forestUpgradesOwned >= 1) {
            TotalClicks += forestClickerPerSecond;
            ClicksTotalText.text = TotalClicks.ToString("0");
        }
        if(bakeryUpgradesOwned >= 1) {
            TotalClicks += bakeryClickerPerSecond;
            ClicksTotalText.text = TotalClicks.ToString("0");
        }
        if(magicUpgradesOwned >= 1) {
            TotalClicks += magicClickerPerSecond;
            ClicksTotalText.text = TotalClicks.ToString("0");
        }
        if(darkMatterUpgradesOwned >= 1) {
            TotalClicks += darkMatterClickerPerSecond;
            ClicksTotalText.text = TotalClicks.ToString("0");
        }
        if(multiverseUpgradesOwned >= 1) {
            TotalClicks += multiverseClickerPerSecond;
            ClicksTotalText.text = TotalClicks.ToString("0");
        }
    }
}
