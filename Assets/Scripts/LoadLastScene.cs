using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadLastScene : MonoBehaviour {

    public string lastScene;
    GameObject[] sceneTrackCounter;

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);

        findTrackerCount();
    }

    void Update()
    {
        if (!SceneManager.GetActiveScene().name.Equals("GameOver"))
        {
            lastScene = SceneManager.GetActiveScene().name;
        }
    }

    internal void LoadPreviousScene()
    {
        SceneManager.LoadScene(lastScene);
    }

    void findTrackerCount()
    {
        int counter = 0;

        //is there a better way for the foreach???
        sceneTrackCounter = GameObject.FindGameObjectsWithTag("sceneTracker");
        foreach (GameObject sceneTracker in sceneTrackCounter)
        {
            counter++;
        }
        if (counter > 1)
            Destroy(this.gameObject);
    }
}
