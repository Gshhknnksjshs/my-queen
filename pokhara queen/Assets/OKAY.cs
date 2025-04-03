using UnityEngine;
using UnityEngine.SceneManagement; // Import SceneManagement to load scenes
using UnityEngine.UI; // Import UI to access Button component

public class okayButtonScript : MonoBehaviour
{
    // Reference to the button component
  public void okayGame()
    {
         SceneManager.LoadScene("pokhara 3");
    }

}
