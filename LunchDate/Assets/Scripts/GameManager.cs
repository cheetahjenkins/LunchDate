using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void GameOver(EventData data)
    {
        SceneManager.LoadScene("GameOverScene");
    }
}
