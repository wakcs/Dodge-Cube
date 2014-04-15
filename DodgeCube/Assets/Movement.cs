using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

    public float movementSpeed;
	// Use this for initialization
	void Start () {
        Debug.Log("Movement Speed is: " + movementSpeed);
	}

    

	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.forward * movementSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            transform.Translate(Vector3.left * movementSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            transform.Translate(Vector3.right * movementSpeed * Time.deltaTime);
        Vector3 pos = transform.position;
        if (pos.z >= 40)
        {
            pos.z = 0;
            transform.position = pos;
        }

	}
}
