using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMain : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//GameObject button = GameObject.Instantiate(Resources.Load<GameObject>("button")) as GameObject;

		GameObject button = GameObject.Instantiate(Resources.Load<GameObject>("button")) as GameObject;
		print(button);
		button.transform.parent = transform;
		button.transform.localPosition = Vector3.zero;
		button.transform.localScale = Vector3.one;

		GameObject AObj = transform.Find("MainA").gameObject;

		GameObject BObj = transform.Find("MainB").gameObject;

		button.transform.SetSiblingIndex(AObj.transform.GetSiblingIndex());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
