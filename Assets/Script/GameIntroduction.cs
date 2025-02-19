using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class GameIntroduction : MonoBehaviour
{
    // Start is called before the first frame update

    public static GameIntroduction instance;
    public GameObject introImage;
    public GameObject finishPanel;
    public GameObject sceneSwitchButton01;
    public GameObject sceneSwitchButton02;
    public GameObject backMainButton; 

    public float time = 30f;
    public float initialTime = 30f; 
    public TextMeshProUGUI countdownText;
    public GameObject countdown;
    public GameObject itemSelectionUI;
    
    private bool isTimeOut = false;
    private bool isGameStarted = false;
    public ItemData itemData; 
    
   
    void Awake()
    {   

        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); 
        }
        else
        {
            Destroy(gameObject); 
        }
    }

    void Start()
    {
        introImage.SetActive(true);
        finishPanel.SetActive(false); 
        countdown.SetActive(false); 
        itemSelectionUI.SetActive(false);
        sceneSwitchButton01.SetActive(false);
        sceneSwitchButton02.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameStarted) 
        {
            Countdown();
        }
    }


    public void StartGame()
    {
        introImage.SetActive(false); 
        isGameStarted = true;
        countdown.SetActive(true);  
        itemSelectionUI.SetActive(true);
        sceneSwitchButton01.SetActive(true);
        sceneSwitchButton02.SetActive(true);
    }

    private void Countdown()
    {
        if(isTimeOut == false)
        {
            time -= Time.deltaTime;
            countdownText.text = "Countdown: " + time.ToString("0" + "s.");
        }
        if(time <= 0)
        {
            isTimeOut = true;
            countdownText.text = "00:00";
            GameOver();
        }
    }

    public void GoToBathroom()
    {
        SceneManager.LoadScene(2); 
    }
    public void GoOut()
    {
        SceneManager.LoadScene(3); 
    }


    private void GameOver()
    {   itemData.ClearData();
        finishPanel.SetActive(true);
        countdown.SetActive(false);
        itemSelectionUI.SetActive(false);
        sceneSwitchButton01.SetActive(false);
        sceneSwitchButton02.SetActive(false);
    }

    public void ReplayGame()
    { 
        itemData.ClearData();
        Destroy(gameObject); 
        SceneManager.LoadScene(1); 
        time = 30f;
    }


    public void ChangeScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }

    public void BackToMainMenu()
    {   
        GameObject[] allObjects = FindObjectsOfType<GameObject>();
        foreach (GameObject obj in allObjects)
        {
            if (obj.scene.buildIndex == -1)
            {
                Destroy(obj);
            }
        }

        Time.timeScale = 1f;

        SceneManager.LoadScene(0);
    }
}