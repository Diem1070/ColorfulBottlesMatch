using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Load scene

public class SceneNavigator : MonoBehaviour
{
    // Method to navigate to Main Menu
    public void GotoMainMenu()
    {
        SceneManager.LoadScene("MainMenuScene");
    }
    // Method to navigate to List Levels
    public void GotoListLevels()
    {
        SceneManager.LoadScene("ListLevelsScene");
    }
    // Method to navigate to Set Level
    public void GotoSetLevel()
    {
        SceneManager.LoadScene("SetLevelScene");
    }
    // Method to navigate to Guide
    public void GotoGuide()
    {
        SceneManager.LoadScene("GuideScene");
    }
    // Method to navigate to Setting
    public void GotoSetting()
    {
        SceneManager.LoadScene("SettingScene");
    }
    // Method to navigate to Game Play
    public void GotoGamePlay()
    {
        SceneManager.LoadScene("GamePlayScene");
    }
}
