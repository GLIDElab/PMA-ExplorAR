using UnityEngine;
using System.Collections;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine.UI;

public class PuzzleScript : MonoBehaviour {

	public GameControl controller;

	public int count;
	public Text puzzleTitle;

	public bool piece1;
	public bool piece2;
	public bool piece3;
	public bool piece4;
	public bool piece5;
	public bool piece6;
	public bool piece7;
	public bool piece8;
	public bool piece9;
	public bool piece10;
	public bool piece11;
	public bool piece12;

	public int x;

	public GameObject mypiece1;
	public GameObject mypiece2;
	public GameObject mypiece3;
	public GameObject mypiece4;
	public GameObject mypiece5;
	public GameObject mypiece6;
	public GameObject mypiece7;
	public GameObject mypiece8;
	public GameObject mypiece9;
	public GameObject mypiece10;
	public GameObject mypiece11;
	public GameObject mypiece12;

	void Start ()
	{
		puzzleTitle.text = "???";

		mypiece1.SetActive (false);
		mypiece2.SetActive (false);
		mypiece3.SetActive (false);
		mypiece4.SetActive (false);
		mypiece5.SetActive (false);
		mypiece6.SetActive (false);
		mypiece7.SetActive (false);
		mypiece8.SetActive (false);
		mypiece9.SetActive (false);
		mypiece10.SetActive (false);
		mypiece11.SetActive (false);
		mypiece12.SetActive (false);

		controller = GameObject.FindWithTag ("Controller").GetComponent<GameControl>();
		count = controller.puzzlePieces;

		if (count == 13) 
		{
			puzzleTitle.text = "Constantine Directing the Building of Constantinople";
		}

		if (controller.piece1Found == true) 
		{
			mypiece1.SetActive (true);
		}
		if (controller.piece2Found == true) 
		{
			mypiece2.SetActive (true);
		}
		if (controller.piece3Found == true) 
		{
			mypiece3.SetActive (true);
		}
		if (controller.piece4Found == true) 
		{
			mypiece4.SetActive (true);
		}
		if (controller.piece5Found == true) 
		{
			mypiece5.SetActive (true);
		}
		if (controller.piece6Found == true) 
		{
			mypiece6.SetActive (true);
		}
		if (controller.piece7Found == true) 
		{
			mypiece7.SetActive (true);
		}
		if (controller.piece8Found == true) 
		{
			mypiece8.SetActive (true);
		}
		if (controller.piece9Found == true) 
		{
			mypiece9.SetActive (true);
		}
		if (controller.piece10Found == true) 
		{
			mypiece10.SetActive (true);
		}
		if (controller.piece11Found == true) 
		{
			mypiece11.SetActive (true);
		}
		if (controller.piece12Found == true) 
		{
			mypiece12.SetActive (true);
		}

		//mypiece1 = GameObject.FindWithTag ("Piece1");
		//mypiece2 = GameObject.FindWithTag ("Piece2");
		//mypiece3 = GameObject.FindWithTag ("Piece3");
		//mypiece4 = GameObject.FindWithTag ("Piece4");

		//mypiece1.SetActive (true);
		//mypiece2.SetActive (true);
		//mypiece3.SetActive (true);
		//mypiece4.SetActive (true);

		//if (piece1 == false) 
		//{
			//mypiece1.SetActive (false);
		//}
		//if (piece2 == false) 
		//{
			//mypiece2.SetActive (false);
		//}
		//if (piece3 == false) 
		//{
			//mypiece3.SetActive (false);
		//}
		//if(piece4 == false) 
		//{
			//mypiece4.SetActive (false);
		//}
	}

	//public void activatePieces()
	//{
		//if (x == 0) 
		//{
			//mypiece1.SetActive (false);
			//mypiece2.SetActive (false);
			//mypiece3.SetActive (false);
			//mypiece4.SetActive (false);
		//}
		//if (x >= 0) 
		//{
			//piece1 = true;
			//mypiece1.SetActive (true);
		//}
		//if (x >= 1) 
		//{
			//piece2 = true;
			//mypiece2.SetActive (true);
		//}
		//if (x >= 2) 
		//{
			//piece3 = true;
			//mypiece3.SetActive (true);
		//}
		//if (x >= 3) 
		//{
			//piece4 = true;
			//mypiece4.SetActive (true);
		//}
		//x += 1;
		//Save ();
	//}

	//public void Save()
	//{
		//BinaryFormatter bf = new BinaryFormatter ();
		//FileStream file = File.Create (Application.persistentDataPath + "/playerInfo.dat");

		//PlayerData data = new PlayerData ();

		//data.piece1 = piece1;
		//data.piece2 = piece2;
		//data.piece3 = piece3;
		//data.piece4 = piece4;
		//data.x = x;

		//bf.Serialize (file, data);
		//file.Close ();
	//}

	//public void Load()
	//{
		//mypiece1 = GameObject.FindWithTag ("Piece1");
		//mypiece2 = GameObject.FindWithTag ("Piece2");
		//mypiece3 = GameObject.FindWithTag ("Piece3");
		//mypiece4 = GameObject.FindWithTag ("Piece4");

		//if (File.Exists (Application.persistentDataPath + "/playerInfo.dat"))
		//{
			///BinaryFormatter bf = new BinaryFormatter ();
			//FileStream file = File.Open (Application.persistentDataPath + "/playerInfo.dat", FileMode.Open);
			//PlayerData data = (PlayerData)bf.Deserialize (file);
			//file.Close ();

			//piece1 = data.piece1;
			//piece2 = data.piece2;
			//piece3 = data.piece3;
			//piece4 = data.piece4;
			//x = data.x;
		//}
	//}
}