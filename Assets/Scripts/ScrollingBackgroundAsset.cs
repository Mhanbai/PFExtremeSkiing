using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBackgroundAsset : MonoBehaviour {
	//Editor variables
	[SerializeField] private float speed;

	//Reference variables
	private SpriteRenderer myRenderer;

	void Start() {
		myRenderer = GetComponent<SpriteRenderer> ();
	}

	// Update is called once per frame
	void Update () {
		Vector3 offset = new Vector3 (Time.time * speed, 0.0f, 0.0f);
		myRenderer.material.mainTextureOffset = offset;
	}
}
