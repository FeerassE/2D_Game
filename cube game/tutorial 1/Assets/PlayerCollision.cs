
using UnityEngine;

public class PlayerCollision : MonoBehaviour {
    public PlayerMovement movement;
	// Use this for initialization
	void OnCollisionEnter(Collision collisioninfo)
    {
        if (collisioninfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
        }
    }
}
