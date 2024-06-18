
using UnityEngine;

public class Followplayer : MonoBehaviour
{
    public Vector3 offset;
    public Transform player;


    void Update()
    {
        transform.position = player.position + offset;
    }
}
