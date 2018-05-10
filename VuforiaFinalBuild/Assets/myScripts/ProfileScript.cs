using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProfileScript : MonoBehaviour {

	public GameControl controller;
	public Text LevelTitleText;
	public Text LevelNumText;
	public Text stat1;
	public Text stat2;
	public Text stat3;

	public Slider mainSlider;

	void Start()
	{

		controller = GameObject.FindWithTag ("Controller").GetComponent<GameControl>();
		stat1.text = controller.worksScanned.ToString ();
		stat2.text = controller.puzzlePieces.ToString ();
		stat3.text = controller.hintsCollected.ToString ();

		LevelTitleText.text = controller.title;
		LevelNumText.text = controller.level.ToString ();
		mainSlider.value = controller.exp;
	}

}
