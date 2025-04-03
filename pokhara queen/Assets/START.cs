using UnityEngine;
using UnityEngine.SceneManagement; // Import SceneManagement to load scenes
using UnityEngine.UI; // Import UI to access Button component

public class startButtonScript : MonoBehaviour
{
    // Reference to the button component
    public void PlayGame()
    {
         SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}