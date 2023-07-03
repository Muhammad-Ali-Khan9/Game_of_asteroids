using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HUD : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI Score;

    float elapsedSeconds;
    bool running = true;

    // Start is called before the first frame update
    void Start()
    {
        Score.SetText("Time Elapsed: " + elapsedSeconds);
    }

    // Update is called once per frame
    void Update()
    {
        if (running)
        {
            elapsedSeconds += Time.deltaTime;
            Score.SetText("Time Elapsed: " + elapsedSeconds);
        }
    }

    public void StopGameTimer()
    {
        running = false;
    }

    
}
