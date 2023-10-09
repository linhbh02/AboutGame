using UnityEngine.SceneManagement;
using UnityEngine;

public class AboutGame : MonoBehaviour
{
    
    public void BackButton()
    {
        SceneManager.LoadScene(1); // Load scene menu khi nhấn vào button
    }
}
