using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

    public Rigidbody2D ball;
    public int speed;
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.D))
        {
            ball.AddForce(new Vector2(speed, 0), ForceMode2D.Force);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            ball.AddForce(new Vector2(speed, 0), ForceMode2D.Force);
        }
          if (Input.GetKey(KeyCode.A))
        {
            ball.AddForce(new Vector2(-speed, 0), ForceMode2D.Force);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            ball.AddForce(new Vector2(-speed, 0), ForceMode2D.Force);
        }

    }
}
