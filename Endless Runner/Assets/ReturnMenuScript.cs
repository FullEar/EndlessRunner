using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnMenuScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void PlayGame()
    {
        SceneManager.LoadScene("FirstLevel");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
