using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// allows us to use scene management
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour {

    public string sceneToLoad;

    //unity calls this function when something collides with player
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //check if the thing we collided with has a player script
        Player playerScript = collision.collider.GetComponent<Player>();

        //only do something if the thing we ran into has a player script
        if (playerScript != null)
        {
            //we DID hit the player
            //GO TO NEXT LEVEL
            SceneManager.LoadScene(sceneToLoad);
        }
    }

}
