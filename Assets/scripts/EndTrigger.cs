
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public Gamemanager gameManager;
    void OnTriggerEnter(Collider other) 
    {
        if(other.tag == "Player")
        {
            Debug.Log("Game Won");
        gameManager.CompleteLevel();
    }
        }
        
    
}
