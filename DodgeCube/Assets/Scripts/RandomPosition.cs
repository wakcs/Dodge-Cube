using UnityEngine;
using System.Collections;
using System.Threading;

public class RandomPosition : MonoBehaviour {

    public Transform target;
    public Transform prefab;
	// Use this for initialization
	void Start () {
        Vector3 pos = transform.position;
        pos.x = Random.Range(-4, 4);
        pos.y = Random.Range(10, 42);
        transform.position = pos;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        Vector3 pos = transform.position;
        pos.x = Random.Range(-4, 4);
        pos.y = Random.Range(5, 42);
        if (target.position.y <= 0.01 )
            Instantiate(prefab, pos, Quaternion.identity);
	}
}
