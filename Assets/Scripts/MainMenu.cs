using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void OnPlayClicked()
    {
        SceneManager.LoadScene("Level1");
    }
    public void OnDontPlayClicked()
    {
        Application.Quit();
    }
}
