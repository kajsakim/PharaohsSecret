using UnityEngine.SceneManagement;
using UnityEngine;

public class Menu_Manager_Se : MonoBehaviour
{
    public void PlaySceneGame ()
    {
        SceneManager.LoadScene(2);
    }

    public void PlaySceneControls ()
    {
        SceneManager.LoadScene(1);
    }
    public void PlaySceneCredits ()
    {
        SceneManager.LoadScene(4);
    }
    public void ExitGame ()
    {
        Application.Quit();
    }

    public void PlaySceneMainMenu ()
    {
        SceneManager.LoadScene(0);
    }

    public void PlaySceneReload ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
