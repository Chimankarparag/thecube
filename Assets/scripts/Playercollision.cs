
using UnityEngine;

public class Playercollision : MonoBehaviour

{
    public Playermovement movement;
     
    void OnCollisionEnter(Collision collsioninfo)
    {
        if(collsioninfo.collider.tag == "obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<Gamemanager>().Endgame();
        }
    }
}

