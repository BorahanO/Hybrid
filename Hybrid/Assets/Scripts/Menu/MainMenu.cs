using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void LoadNextScene()
    {
        SceneManager.LoadScene("Hub");
    }
    
    public void LoadEndScene()
    {
       //SceneManager.LoadScene(EndScene);
    }
}
