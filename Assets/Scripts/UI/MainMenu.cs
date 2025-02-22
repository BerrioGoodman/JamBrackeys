using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayButton()
    {
        SceneManager.LoadScene("Level1");
    }
    public void CreditsButton()
    {
        SceneManager.LoadScene("Credits");
    }
    public void QuitButton()
    {
        Application.Quit();
    }
    public void BackButton()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
