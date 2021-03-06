using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DelayedStart : MonoBehaviour
{
    public GameObject countDown;
    public static GameTimer instance;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine ("StartDelay");
        GameTimer.instance.BeginTimer();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator StartDelay() {
        Time.timeScale = 0;
        float pauseTime = Time.realtimeSinceStartup + 3f;
        while (Time.realtimeSinceStartup < pauseTime)
            yield return 0;
        countDown.gameObject.SetActive(false);
        Time.timeScale = 1;
        GameTimer.instance.BeginTimer();

    }


}
