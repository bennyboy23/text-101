using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextController : MonoBehaviour {
	public Text text;
	private enum States
	{
		cell,
		mirror,
		sheets_0,
		sheets_1,
		lock_0,
		lock_1
	};
	private States myState;
	// Use this for initialization
	void Start () {
		myState = States.cell;
		text.text = "press down arrow to start";
	}
	
	// Update is called once per frame
	void Update () {
		if(myState == States.cell){
			state_cell ();
		}

	}

	void state_cell(){
		text.text = "You are in a prison cell, and you want to escape. There are " +
			"some dirty sheets on the bed, a mirror on the wall and a locked door \n" +
			"press S for sheets \n" + "press M for mirror \n" + "press L for lock";
			if(Input.GetKeyDown(KeyCode.S)){
				myState = States.sheets_0;
			}
	}
}
