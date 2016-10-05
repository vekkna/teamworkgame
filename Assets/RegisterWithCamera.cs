using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class RegisterWithCamera : NetworkBehaviour {

	// Use this for initialization
	void Start () {
		if (!isLocalPlayer)
		{
			// exit from update if this is not the local player
			return;
		}
		Camera.main.GetComponent<Follow> ().target = transform;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
