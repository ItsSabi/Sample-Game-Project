
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement;

    

    void OnCollisionEnter(Collision collisionInfo)
    {


        if (collisionInfo.collider.tag == "Obstacle")
        {
       
            //Disable player movement when they crash
            movement.enabled = false;
            //Ends the game
            FindObjectOfType<GameManager>().EndGame();




        }

    }



}
