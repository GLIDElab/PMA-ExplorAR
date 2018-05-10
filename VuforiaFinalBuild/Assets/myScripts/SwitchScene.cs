using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour {

	public GameControl game;

	public GameObject nothingThere;
	public GameObject hint;
	public GameObject puzzlePiece;
	public GameObject profile;
	public GameObject map;
	public GameObject database;
	public GameObject puzzlePiece002;

	void Start() { 
		game = GameObject.FindWithTag ("Controller").GetComponent<GameControl> ();
	}

	public void MainScene () 
	{
		SceneManager.LoadScene(0);
	}

	public void HintScene () 
	{
		hint.SetActive (true);
	}

	public void HintSceneClose () {
		hint.SetActive (false);
	}

	public void PuzzleScene () 
	{
		game.isWriting = true;
		puzzlePiece.SetActive (true);
	}

	public void PuzzleSceneClose () {
		puzzlePiece.SetActive (false);
	}

	public void NothingScene () 
	{
		nothingThere.SetActive (true);
	}

	public void NothingSceneClose () {
		nothingThere.SetActive (false);
	}

	public void ProfileScene () 
	{
		profile.SetActive (true);
	}

	public void ProfileSceneClose () {
		profile.SetActive (false);
	}

	public void MapScene () 
	{
		map.SetActive (true);
	}
	public void MapSceneClose () 
	{
		map.SetActive (false);
	}

	public void DatabaseScene () 
	{
		database.SetActive (true);
	}

	public void DatabaseSceneClose () {
		database.SetActive (false);
	}

	public void PuzzlePieceOpen () {
		puzzlePiece002.SetActive (true);
	}

	public void PuzzlePieceClose () {
		puzzlePiece002.SetActive (false);
	}

	public void Quit ()
	{
		Application.Quit ();
	}
}
