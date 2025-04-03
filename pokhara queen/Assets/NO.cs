using UnityEngine;
using UnityEngine.SceneManagement; // Import SceneManagement to load scenes
using UnityEngine.UI; // Import UI to access Button component

public class noButtonScript : MonoBehaviour
{
     public void noGame()
    {
         SceneManager.LoadScene(3);
    }

}
 
