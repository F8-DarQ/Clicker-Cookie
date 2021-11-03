using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour {
    public Text ClicksTotalText;
    public Text ClickerUpgradesOwnedText;
    
    float TotalClicks;
    public float clickerUpgradeCost;
    float clickerUpgradesOwned;

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
        }
    }
}
