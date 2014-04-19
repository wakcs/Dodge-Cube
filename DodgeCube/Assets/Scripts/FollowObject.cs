using UnityEngine;
using System.Collections;

public class FollowObject : MonoBehaviour {

    public Transform target;
    public float forward;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void LateUpdate () {
        transform.position = target.position;
        transform.position += Vector3.back * 2;
        transform.position += Vector3.up * forward;
        Vector3 pos = transform.position;
        pos.x = 0;
        transform.position = pos;
	}
}
