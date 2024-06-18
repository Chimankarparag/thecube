
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour
{
    bool gamehasended = false;
    public GameObject completelevelUI;
    public void CompleteLevel(){
        Debug.Log("Game Won");
        completelevelUI.SetActive(true);
    }
    public void Endgame()
        {
        if(gamehasended == false)
        {
            gamehasended = true;
            Debug.Log("GAME OVER");
            Restart();

        }

        void Restart()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        }
        
        

    }
}
