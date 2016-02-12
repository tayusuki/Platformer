using UnityEngine;
using System.Collections;

public class PlayerJump : MonoBehaviour {

    public float jumpForce;
    public Rigidbody2D ball;
    public int jumpcount = 3;
    public int maxJumpCount = 3;
	
	// Update is called once per frame
	void Update () {
        if (jumpcount > 0)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                ball.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
                jumpcount--;
            }
            else if (Input.GetKeyDown(KeyCode.W))
            {
                ball.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
                jumpcount--;
            }
            else if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                ball.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
                jumpcount--;
            }
        }
	}

    void OnCollisionEnter2D(Collision2D hitItem)
    {
        if (hitItem.gameObject.tag == "ground")
        { //Checks what you are hitting whether it has the tag ground
            jumpcount = maxJumpCount;
        }
    }
}
