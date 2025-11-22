using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [SerializeField] private GameObject _homePopup;
    [SerializeField] private GameObject _settingsPopup;
    [SerializeField] private Button _mainMenuButton;
    [SerializeField] private Button _homeButton;
    private void Awake()
    {
        _homePopup.SetActive(false);
        _settingsPopup.SetActive(false);
    }
    public void HomePopup()
    {
        _homePopup.SetActive(true); 
    }
    public void ClosePopup()
    {
        _homePopup.SetActive(false);
    }
    public void SettingsPopup()
    {
        _settingsPopup.SetActive(true); 
    }
    public void CloseSettings()
    {
        _settingsPopup.SetActive(false);
    }
    public void MainMenu()
    {
        _mainMenuButton.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("MenuScene");
        });
    }
    public void HomeButton()
    {
        _homeButton.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("MenuScene");
        });
    }



}
