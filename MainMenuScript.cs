using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    private void start()
    {
        creditsPanel.SetActive(false);
    }
    public GameObject creditsPanel;
    public void PlayGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void Credits()
    {
        creditsPanel.SetActive(true);
    }
    public void Back()
    {
        creditsPanel.SetActive(false);
    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("QuitGame");
    }
    
}
