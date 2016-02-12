using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LiveTracker : MonoBehaviour {

    public int lives = 3;
    GameObject[] liveTrackerCounter;

    void Start()
    {

    }
	void Awake () {
        DontDestroyOnLoad(this.gameObject);
        findTrackerCount();
    }
	
	void OnLevelWasLoaded (int level) {
        if (level == 4)
        {
            lives--;
        }
    }

    void findTrackerCount()
    {
        int counter = 0;

        //is there a better way for the foreach???
        liveTrackerCounter = GameObject.FindGameObjectsWithTag("sceneTracker");
        foreach (GameObject liveTracker in liveTrackerCounter)
        {
            counter++;
        }
        if (counter > 1)
            Destroy(this.gameObject);
    }
}
