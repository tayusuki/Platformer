using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour {

    public string sceneName;

    void OnTriggerEnter2D()
    {
        SceneManager.LoadScene(sceneName);
    }
}
