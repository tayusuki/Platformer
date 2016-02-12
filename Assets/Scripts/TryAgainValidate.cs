using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TryAgainValidate : MonoBehaviour {

    LiveTracker gameOverTrigger;
    LoadLastScene player;

    //get access to my ball object, because I need THAT instance of the GameOverTrigger.
    //Otherwise, it might always think that lives = 3. Afterall, I can 
    //attach the script to multiple things. If I have access to the COPY of the script
    //that is on my player, I will have access to the player's current lives. In theory.

    //The same principle I think applies to the LoadLastScene. However I don't need access to the 
    //ball for that. What I need access to is my blank GameObject that has the script, with the 
    //previous scene name recorded.

    //Still find out how to access scripts for future reference from Castalia. 
    void Start()
    {
        player = Object.FindObjectOfType<LoadLastScene>();
        gameOverTrigger = Object.FindObjectOfType<LiveTracker>();
        if (gameOverTrigger.lives < 0)
        {
            GetComponent<Image>().color = Color.black;
            //change button color
        }
    }
	public void Clicked() {
        //If there's enough lives, allow the player to restart the current level

       if (gameOverTrigger.lives >= 0) {
            player.LoadPreviousScene();
        }
	}
}
