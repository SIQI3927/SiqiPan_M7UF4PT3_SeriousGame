using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public GameObject introImage;
    public TextMeshProUGUI text;
    public GameObject countdown;
    public GameObject finishPanel;
    public Button replayButton;
    public Button sceneSwitchButton01;
    public Button sceneSwitchButton02;
    public Button backMainButton;

    void Start()
    {
        GameIntroduction.instance.countdownText = text;
        GameIntroduction.instance.introImage = introImage;
        GameIntroduction.instance.countdown = countdown;
        GameIntroduction.instance.finishPanel = finishPanel;

        replayButton.onClick.AddListener(GameIntroduction.instance.ReplayGame);
        sceneSwitchButton01.onClick.AddListener(GameIntroduction.instance.GoToBathroom);
        sceneSwitchButton02.onClick.AddListener(GameIntroduction.instance.GoOut);
        backMainButton.onClick.AddListener(GameIntroduction.instance.BackToMainMenu);
    }


    public void GoBackToPreviousScene()
    {
        SceneManager.LoadScene(1); 
    }

}