using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

	public Transform player;
	Vector3 Distance;
	// Use this for initialization
	void Start () {
		Distance = transform.position - player.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
		transform.position = player.position + Distance;
	}
}
