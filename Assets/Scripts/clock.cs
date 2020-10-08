using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class clock : MonoBehaviour
{
    private Text timerText;
    private float levelTime;

    // Start is called before the first frame update
    void Start()
    {
        ResetTimer();
        timerText = GetComponent<Text>();
    }

    public void ResetTimer()
    {
        if (levelTime == 60f)
        {
         //   SceneManager.LoadScene("startScene");
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (levelTime >= 0.0)
        {
            levelTime += Time.deltaTime;
            int min = Mathf.FloorToInt(55 + (levelTime / 60));
            timerText.text = "8" + ":" + min.ToString("00") + "pm";

        }
    }
}