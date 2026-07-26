using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovements movement;
    
    void OnCollisionEnter(Collision collisioninfo)
    {
        if (collisioninfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindAnyObjectByType<GameManager>().EndGame();
        }
    }
}
