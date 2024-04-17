using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class deathscreen : MonoBehaviour
{
    public Text puntajefinalText;
    public Score highscore;

    void Start()
    {
        gameObject.SetActive(false);
    }


    public void ActivateScreen()
    {
        gameObject.SetActive(true);
        Time.timeScale = 0f;
        //puntajefinalText.text = (highscore.contadorScore * 10).ToString("0");
    }

    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

