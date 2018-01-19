/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class painterClick : MonoBehaviour {

	public Camera mainCamera;
	public Texture2D splashTexture;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
		{
			RaycastHit hit;
			if (Physics.Raycast(mainCamera.transform.position, mainCamera.transform.forward, out hit))
			{
				//MyShader script = hit.collider.gameObject.GetComponent < MyShader;>();
				//if (null != script)
				//	script.PaintOn(hit.textureCoord, splashTexture);
			}
		}
	}
}
*/