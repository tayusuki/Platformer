using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LivesHUD : MonoBehaviour {

    public GameObject textUI;
    Text text;
    LiveTracker trackerObjectInHeirarchy;

	// Use this for initialization
	void Start () {
        trackerObjectInHeirarchy = Object.FindObjectOfType<LiveTracker>();
        text = textUI.GetComponent<Text>();
        text.text = "Lives: " + trackerObjectInHeirarchy.lives;
	}
}
