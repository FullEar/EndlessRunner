using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("LevelSelection");
    }

    public void GunInventory()
    {
        SceneManager.LoadScene("GunInventory");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
