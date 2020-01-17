using UnityEngine;
     using UnityEngine.SceneManagement;
     using System.Collections;
     
     public class MainMenu : MonoBehaviour
{

    public void RestartGame()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name); // loads current scene
        Application.LoadLevel(0);
    }

}