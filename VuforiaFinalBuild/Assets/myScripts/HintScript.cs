using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HintScript : MonoBehaviour {

	public GameControl controller;
	public string myClue;
	public Text myHint;

	// Use this for initialization
	void Start () 
	{
		controller = GameObject.FindWithTag ("Controller").GetComponent<GameControl>();
		myClue = controller.clue1;
	}
	
	// Update is called once per frame

}
