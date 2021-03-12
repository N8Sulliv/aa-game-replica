using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void playGame()
    {
        SceneManager.LoadScene("Level1");
    }

    public void options()
    {
        SceneManager.LoadScene("Options");
    }

    public void exit()
    {
        Application.Quit();
    }

    public void back()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void restart()
    {
        SceneManager.LoadScene("Level1");
    }

    public void backToStart()
    {
        SceneManager.LoadScene("Start");
    }
}
