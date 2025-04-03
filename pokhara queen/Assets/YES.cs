using UnityEngine;
using UnityEngine.SceneManagement; // Import SceneManagement to load scenes
using UnityEngine.UI; // Import UI to access Button component

public class yesButtonScript : MonoBehaviour
{
  public void yesGame()
    {
         SceneManager.LoadScene("pokhara 3");
    }

}