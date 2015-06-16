using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Rigidbody2D r = gameObject.GetComponent<Rigidbody2D>();
        Vector2 velocity = r.velocity;
        velocity.x = 10f;
        gameObject.GetComponent<Rigidbody2D>().velocity = velocity;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 600f));
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            Rigidbody2D r = gameObject.GetComponent<Rigidbody2D>();
            Vector2 velocity = r.velocity;
            velocity.x = 0;
            gameObject.GetComponent<Rigidbody2D>().velocity = velocity;
        }

        if (Input.GetKey(KeyCode.D))
        {

            gameObject.GetComponent<Rigidbody2D>().AddRelativeForce(new Vector2(100, 0f));
        }
        if (Input.GetKey(KeyCode.A))
        {

            gameObject.GetComponent<Rigidbody2D>().AddRelativeForce(new Vector2(-100f, 0f));
        }
	}
}
