using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartOverBehavior : MonoBehaviour {

    LiveTracker liveReset;

    void Start()
    {
        liveReset = Object.FindObjectOfType<LiveTracker>();
    }
	// Use this for initialization
	public void Clicked() {
        SceneManager.LoadScene("home");
        liveReset.lives = 3;
	}
}
