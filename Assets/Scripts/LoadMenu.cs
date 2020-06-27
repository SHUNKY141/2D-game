using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadMenu : MonoBehaviour
{
    public void LoadScene()
    {
        int A = SceneManager.GetActiveScene().buildIndex;
        A++;
        SceneManager.LoadScene(A);
    }

    public void ExitButton()
    {
        Application.Quit();
    }

    private void OnGUI()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Menu");
        }
    }
}
