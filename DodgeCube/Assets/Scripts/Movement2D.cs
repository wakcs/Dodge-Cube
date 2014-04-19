using UnityEngine;
using System.Collections;

public class Movement2D : MonoBehaviour {

    public float movementSpeed;
	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void FixedUpdate () {
        transform.Translate(Vector3.up * movementSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            transform.Translate(Vector3.left * movementSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            transform.Translate(Vector3.right * movementSpeed * Time.deltaTime);
        Vector3 pos = transform.position;
        if (pos.y >= 44)
        {
            pos.y = 0;
            transform.position = pos;
        }
	}
}
