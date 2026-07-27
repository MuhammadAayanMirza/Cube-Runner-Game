using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    bool gameHasEnded = false;
    public float restartDelay = 1f;
    public float nextleveldelay = 2f;

    public GameObject completeLevelUI;


        public void completeLevel ()
    {
        completeLevelUI.SetActive(true);
        Invoke("LoadNextLevel", nextleveldelay);
    }

    void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


        void Restart ()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            
        }

        public void EndGame ()
    {   
        if (gameHasEnded == false)
       { 
        gameHasEnded = true;
        Debug.Log("Game Over"); 
        Invoke("Restart", restartDelay);
       }
    }


    
}
