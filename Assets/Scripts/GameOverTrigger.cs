using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameOverTrigger : MonoBehaviour {

    public string sceneName;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -50)
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
