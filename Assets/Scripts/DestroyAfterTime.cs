using UnityEngine;
using System.Collections;

public class DestroyAfterTime : MonoBehaviour {

    public float timeToDestroy;
    private float timeTaken;

	// Update is called once per frame
	void Update () {
        timeTaken += Time.deltaTime;

        if (timeTaken > timeToDestroy)
            Destroy(gameObject);
	}
}
