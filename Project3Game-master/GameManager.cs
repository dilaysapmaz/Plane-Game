
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool GameEnded = false;
    public float restartDelay = 3f;
    public GameObject completeLevelUI;
    public void completeLevel()
    {
        completeLevelUI.SetActive(true);
    }
    public void GameOver()
    {
        if (GameEnded == false)
        {
            GameEnded = true;
            Debug.Log("The Game is Over");
            Invoke("Restart", restartDelay);
        }
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
