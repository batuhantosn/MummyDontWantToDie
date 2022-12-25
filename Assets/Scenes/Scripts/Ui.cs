using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ui : MonoBehaviour
{
    public GameObject menuPanel,settingPanel;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    public void startButton()
    {
        SceneManager.LoadScene("GameScene");
    }
    public void maxscoreButton()
    {
        
    }
    public void settingButton()
    {
        menuPanel.SetActive(false);
        settingPanel.SetActive(true);
    }
    public void exitButton()
    {
        Application.Quit();
    }
    public void controlButton()
    {
       
    }
    public void volumeButton()
    {
        
    }
    public void resetButton()
    {
        
    }
    public void backButton()
    {
        menuPanel.SetActive(true);
        settingPanel.SetActive(false);
    }
}
