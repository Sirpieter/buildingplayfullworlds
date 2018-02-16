using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
	public Color objectcolour = new Color();

	public Renderer objectRenderer;
	// Use this for initialization
	void Start () {
		objectRenderer.material.color = objectcolour;
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(transform.position.x,Mathf.PingPong(Time.time, 3), transform.position.z); 
	}
}