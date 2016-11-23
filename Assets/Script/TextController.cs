using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextController : MonoBehaviour {
	public Text text;
	// Use this for initialization
	void Start () {
		text.text = "press down arrow to start";
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.DownArrow)) {
			text.text = "You are in a prison cell, and you want to escape. There are " +
			"some dirty sheets on the bed, a mirror on the wall and a locked door \n" +
			"press S for sheets \n" + "press M for mirror \n" + "press L for lock";
		}
		if(Input.GetKeyDown(KeyCode.UpArrow)){
			text.text = "up key pressed";
		}
	}
}
