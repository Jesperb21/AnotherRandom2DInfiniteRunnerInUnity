using UnityEngine;
using System.Collections;

public class MoveScript : MonoBehaviour {
    public int speed;

	// Use this for initialization
	void Start () {
        gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(speed, 0));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
