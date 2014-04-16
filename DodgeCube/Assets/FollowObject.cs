using UnityEngine;
using System.Collections;

public class FollowObject : MonoBehaviour {

    public Transform target;
    public int height;

	// Use this for initialization
	void Start () {
        Debug.Log("target is: " + target);
	}
	
	// Update is called once per frame
	void LateUpdate () {
        transform.position = target.position;
        transform.position += Vector3.back * height;
        Vector3 pos = transform.position;
        pos.x = 0;
        transform.position = pos;
	}
}
