using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneController : MonoBehaviour
{
    public void LoadGameOver()
    {
        SceneManager.LoadScene("GameOver");
    }

    public void LoadVictory()
    {
        SceneManager.LoadScene("Victory");
    }
}
