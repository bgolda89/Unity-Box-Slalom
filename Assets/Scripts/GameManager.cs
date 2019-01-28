using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    bool gameHasEnded = false;
    float restartDelay = 2f;
    public GameObject completeLevelUI;

    public void CompleteLevel ()
    {
        completeLevelUI.SetActive(true);
    }

    public void EndGame () {
        if (gameHasEnded == false) 
        {
            Debug.Log("gameOver");
            gameHasEnded = true;
            Invoke("Restart", restartDelay);
        }

    } 
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
