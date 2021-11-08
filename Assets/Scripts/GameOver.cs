using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

    public GameObject gameOverScreen;
    private bool continuePlaying = false;

    void Update() {
        if(GameObject.FindGameObjectWithTag("Manager").GetComponent<Manager>().TotalClicks >= 1000000 && continuePlaying == false) {
            Timer.instance.EndTimer();
            gameOverScreen.SetActive(true);
        }
    }

    public void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Timer.instance.BeginTimer();
    }

    public void Continue() {
        continuePlaying = true;
        gameOverScreen.SetActive(false);
    }
}
