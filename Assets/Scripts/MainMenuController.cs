using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{
    [SerializeField] private Button _playButton;
    [SerializeField] private Button _settingsButton;
    [SerializeField] private Button _exitButton;
    [SerializeField] private Button _mainMenuButton;
    [SerializeField] private GameObject _settingsPopup;
    private void Awake()
    {
        _playButton.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("MainScene");
        });

        _exitButton.onClick.AddListener(ExitGame);

        _settingsButton.onClick.AddListener(SettingsPopup);

        _mainMenuButton.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("MenuScene");
        });

    }
    public void SettingsPopup()
    {
        _settingsPopup.SetActive(true); 
    }
    public void ExitGame()
    {
        Application.Quit();  
    }



}
