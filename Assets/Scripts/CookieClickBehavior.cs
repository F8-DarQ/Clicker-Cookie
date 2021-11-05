using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookieClickBehavior : MonoBehaviour {

    public GameObject target;

    public bool coroutineRunning;

    void Update() {
        transform.Rotate(0,0,50 * Time.deltaTime);
    }

    public void ChangeSize() {
        if(coroutineRunning == false) {
            StartCoroutine(CookieScaling());
        }
    }

    private IEnumerator CookieScaling() {
        coroutineRunning = true;
        transform.localScale -= new Vector3 (0.5f,0.5f,0.5f);
        yield return new WaitForSeconds (1);
        transform.localScale += new Vector3 (0.5f,0.5f,0.5f);
        coroutineRunning = false;
    }
}