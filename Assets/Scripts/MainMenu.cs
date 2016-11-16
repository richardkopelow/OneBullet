using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void OnPlayClicked()
    {
        SceneManager.LoadScene("Level1");
    }
    public void OnDontPlayClicked()
    {
        Application.Quit();
    }
}
