using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine.UI;

public class GameControl : MonoBehaviour {

	public static GameControl control;
	public Clues clueList = new Clues ();
	public Clues clueHolder;
	public int level;
	public int exp;
	public string title;
	public DatabaseController data;
	public GameObject database;

	public int clueNum;
	public Text myHint;

	public string clue1;
	public bool isWriting = false;
	public ClueSending network;

	public Text expText;
	public Text levelText;
	public Text titleText;
	public int puzzlePieces;
	public int worksScanned;
	public int hintsCollected;
	//public GameObject hintbutton1;
	//public GameObject hintbutton2;

	public bool button1on = true;
	public bool button2on = true;
	public bool button3on = true;
	public bool button4on = true;
	public bool button5on = true;
	public bool button6on = true;
	public bool button7on = true;
	public bool button8on = true;
	public bool button9on = true;
	public bool button10on = true;
	public bool button11on = true;
	public bool button12on = true;
	public bool button13on = true;
	public bool button14on = true;
	public bool button15on = true;
	public bool button16on = true;
	public bool button17on = true;
	public bool button18on = true;
	public bool button19on = true;
	public bool button20on = true;
	public bool button21on = true;
	public bool button22on = true;
	public bool button23on = true;
	public bool button24on = true;
	public bool button25on = true;
	public bool button26on = true;
	public bool button27on = true;
	public bool button28on = true;
	public bool button29on = true;
	public bool button30on = true;
	public bool button31on = true;
	public bool button32on = true;
	public bool button33on = true;

	public bool piece1Found = false;
	public bool piece2Found = false;
	public bool piece3Found = false;
	public bool piece4Found = false;
	public bool piece5Found = false;
	public bool piece6Found = false;
	public bool piece7Found = false;
	public bool piece8Found = false;
	public bool piece9Found = false;
	public bool piece10Found = false;
	public bool piece11Found = false;
	public bool piece12Found = false;
	public bool piece13Found = false;
	public bool piece14Found = false;
	public bool piece15Found = false;

	public bool collected = false;

	public GameObject mybutton1;
	public GameObject mybutton2;
	public GameObject mybutton3;
	public GameObject mybutton4;
	public GameObject mybutton5;
	public GameObject mybutton6;
	public GameObject mybutton7;
	public GameObject mybutton8;
	public GameObject mybutton9;
	public GameObject mybutton10;
	public GameObject mybutton11;
	public GameObject mybutton12;
	public GameObject mybutton13;
	public GameObject mybutton14;
	public GameObject mybutton15;
	public GameObject mybutton16;
	public GameObject mybutton17;
	public GameObject mybutton18;
	public GameObject mybutton19;
	public GameObject mybutton20;
	public GameObject mybutton21;
	public GameObject mybutton22;
	public GameObject mybutton23;
	public GameObject mybutton24;
	public GameObject mybutton25;
	public GameObject mybutton26;
	public GameObject mybutton27;
	public GameObject mybutton28;
	public GameObject mybutton29;
	public GameObject mybutton30;
	public GameObject mybutton31;
	public GameObject mybutton32;
	public GameObject mybutton33;

	public GameObject myPopUp;

	public Text myClue; 
	public string jsonHolder;
	public string jsonHolder2;

	[SerializeField]
	public class Clues
	{
		public string clue001;
		public string clue002;
		public string clue003;
		public string clue004;
		public string clue005;
		public string clue006;
		public string clue007;
		public string clue008;
		public string clue009;
		public string clue010;
		public string clue011;
		public string clue012;
		public string clue013;
		public string clue014;
		public string clue015;
		public string clue016;
		public string clue017;
		public string clue018;
		public string clue019;
		public string clue020;
		public string clue021;
		public string clue022;
		public string clue023;
		public string clue024;
		public string clue025;
		public string clue026;
		public string clue027;
		public string clue028;
		public string clue029;
		public string clue030;
		public string clue031;
		public string clue032;
		public string clue033;
		public string clue034;
		public string clue035;
		public string clue036;
		public string clue037;
		public string clue038;
		public string clue039;
		public string clue040;
	}

	// Use this for initialization
	void Awake () 
	{
//		Load ();

		if (button1on == false) 
		{
			mybutton1.SetActive (false);
		}

		if (button2on == false) 
		{
			mybutton2.SetActive (false);
		}

		if (button3on == false) 
		{
			mybutton3.SetActive (false);
		}

		if (button4on == false) 
		{
			mybutton4.SetActive (false);
		}

		if (button5on == false) 
		{
			mybutton5.SetActive (false);
		}

		if (button6on == false) 
		{
			mybutton6.SetActive (false);
		}

		if (button7on == false) 
		{
			mybutton7.SetActive (false);
		}

		if (button8on == false) 
		{
			mybutton8.SetActive (false);
		}

		if (button9on == false) 
		{
			mybutton9.SetActive (false);
		}

		if (button10on == false) 
		{
			mybutton10.SetActive (false);
		}

		if (button11on == false) 
		{
			mybutton11.SetActive (false);
		}

		if (button12on == false) 
		{
			mybutton12.SetActive (false);
		}

		if (button13on == false) 
		{
			mybutton13.SetActive (false);
		}
			
		if (button14on == false) 
		{
			mybutton14.SetActive (false);
		}

		if (button15on == false) 
		{
			mybutton15.SetActive (false);
		}

		if (button16on == false) 
		{
			mybutton16.SetActive (false);
		}

		if (button17on == false) 
		{
			mybutton17.SetActive (false);
		}

		if (button18on == false) 
		{
			mybutton18.SetActive (false);
		}

		if (button19on == false) 
		{
			mybutton19.SetActive (false);
		}

		if (button20on == false) 
		{
			mybutton20.SetActive (false);
		}

		if (button21on == false) 
		{
			mybutton21.SetActive (false);
		}
		if (button22on == false) 
		{
			mybutton22.SetActive (false);
		}

		if (button23on == false) 
		{
			mybutton23.SetActive (false);
		}

		if (button24on == false) 
		{
			mybutton24.SetActive (false);
		}

		if (button25on == false) 
		{
			mybutton25.SetActive (false);
		}

		if (button26on == false) 
		{
			mybutton26.SetActive (false);
		}

		if (button27on == false) 
		{
			mybutton27.SetActive (false);
		}

		if (button28on == false) 
		{
			mybutton28.SetActive (false);
		}

		if (button29on == false) 
		{
			mybutton29.SetActive (false);
		}

		if (button30on == false) 
		{
			mybutton30.SetActive (false);
		}

		if (button31on == false) 
		{
			mybutton31.SetActive (false);
		}

		if (button32on == false) 
		{
			mybutton32.SetActive (false);
		}

		if (button33on == false) 
		{
			mybutton33.SetActive (false);
		}



			
		if (control == null) 
		{
			DontDestroyOnLoad (gameObject);
			control = this;
		} 
		else if (control != this) 
		{
			Destroy (gameObject);
		}

	}

	void Start () {
		jsonHolder = PackageList (clueList);
	}
		
	void Update()
	{
//		if (button1on == false) 
//		{
//			myClue = GameObject.FindWithTag ("Clue").GetComponent<Text>();
//			myClue.text = "Ur a bum";
//		}

		myPopUp = GameObject.FindWithTag ("PopUp");
		if (myPopUp != null) 
		{
			if (collected == true) 
			{
				myPopUp.SetActive (false);
			}
			else if (piece2Found == true) 
			{
				if (collected == true) 
				{
					myPopUp.SetActive (false);
				}
			}
			else if (piece1Found == true) 
			{
				if (collected == true) 
				{
					myPopUp.SetActive (false);
				}
			}
		}

		//if (isWriting == true) {
			//network = GameObject.FindWithTag ("network").GetComponent<ClueSending> ();
			//clue1 = network.clue;
		//}



		//if (hintbutton1 == null) 
		//{
			//hintbutton1 = GameObject.FindWithTag ("Button");
		//}
		//if (hintbutton2 == null) 
		//{
			//hintbutton2 = GameObject.FindWithTag ("Button2");
		//}

		//if (button1on == false) 
		//{
			//hintbutton1.SetActive (false);
		//}
		//if (button2on == false) 
		//{
			//hintbutton2.SetActive (false);
		//}
	}

	public void AddToDatabase () {
		database.SetActive (true);
		data.CreateButton ();
		database.SetActive (false);
	}

	public string PackageList (Clues cluelist) {
		clueList.clue001 = "This is the first clue.";
		string json = JsonUtility.ToJson (clueList);
		return json;
	}

	public void AddClue () {
		jsonHolder2 = SaveClue (jsonHolder, clue1);
		DisplayClue (jsonHolder2);
	}

	public string SaveClue (string json, string currClue) {
		clueList = JsonUtility.FromJson<Clues> (json);

		Debug.Log ("Working1");
		if (clueList.clue001 == null) {
			clueList.clue001 = currClue;
		} else if (clueList.clue002 == "") {
			clueList.clue002 = currClue;
		} else if (clueList.clue003 == "") {
			clueList.clue003 = currClue;
		} else if (clueList.clue004 == "") {
			clueList.clue004 = currClue;
		} else if (clueList.clue005 == "") {
			clueList.clue005 = currClue;
		} else if (clueList.clue006 == "") {
			clueList.clue006 = currClue;
		} else if (clueList.clue007 == "") {
			clueList.clue007 = currClue;
		} else if (clueList.clue008 == "") {
			clueList.clue008 = currClue;
		} else if (clueList.clue009 == "") {
			clueList.clue009 = currClue;
		} else if (clueList.clue010 == "") {
			clueList.clue010 = currClue;
		} else if (clueList.clue011 == "") {
			clueList.clue011 = currClue;
		} else if (clueList.clue012 == "") {
			clueList.clue012 = currClue;
		} else if (clueList.clue013 == "") {
			clueList.clue013 = currClue;
		} else if (clueList.clue014 == "") {
			clueList.clue014 = currClue;
		} else if (clueList.clue015 == "") {
			clueList.clue015 = currClue;
		} else if (clueList.clue016 == "") {
			clueList.clue016 = currClue;
		} else if (clueList.clue017 == "") {
			clueList.clue017 = currClue;
		} else if (clueList.clue018 == "") {
			clueList.clue018 = currClue;
		} else if (clueList.clue019 == "") {
			clueList.clue019 = currClue;
		} else if (clueList.clue020 == "") {
			clueList.clue020 = currClue;
		} else if (clueList.clue021 == "") {
			clueList.clue021 = currClue;
		} else if (clueList.clue022 == "") {
			clueList.clue022 = currClue;
		} else if (clueList.clue023 == "") {
			clueList.clue023 = currClue;
		} else if (clueList.clue024 == "") {
			clueList.clue024 = currClue;
		} else if (clueList.clue025 == "") {
			clueList.clue025 = currClue;
		} else if (clueList.clue026 == "") {
			clueList.clue026 = currClue;
		} else if (clueList.clue027 == "") {
			clueList.clue027 = currClue;
		} else if (clueList.clue028 == "") {
			clueList.clue028 = currClue;
		} else if (clueList.clue029 == "") {
			clueList.clue029 = currClue;
		} else if (clueList.clue030 == "") {
			clueList.clue030 = currClue;
		} else if (clueList.clue031 == "") {
			clueList.clue031 = currClue;
		} else if (clueList.clue032 == "") {
			clueList.clue032 = currClue;
		} else if (clueList.clue033 == "") {
			clueList.clue033 = currClue;
		} else if (clueList.clue034 == "") {
			clueList.clue034 = currClue;
		} else if (clueList.clue035 == "") {
			clueList.clue035 = currClue;
		} else if (clueList.clue036 == "") {
			clueList.clue036 = currClue;
		} else if (clueList.clue037 == "") {
			clueList.clue037 = currClue;
		} else if (clueList.clue038 == "") {
			clueList.clue038 = currClue;
		} else if (clueList.clue039 == "") {
			clueList.clue039 = currClue;
		} else {
			clueList.clue040 = currClue;
		}

		return PackageList (clueList);
	}

	public void DisplayClue(string json) {
		clueList = JsonUtility.FromJson<Clues> (json);

		clueNum = UnityEngine.Random.Range (0, 39);
		Debug.Log ("Working2");
		Debug.Log (clueNum);
		Debug.Log (clueList.clue001);
		Debug.Log (clueList.clue002);
		if (clueNum == 0) {
			myHint.text = clueList.clue001;
		} else if (clueNum == 1) {
			myHint.text = clueList.clue002;
		} else if (clueNum == 2) {
			myHint.text = clueList.clue003;
		} else if (clueNum == 3) {
			myHint.text = clueList.clue004;
		} else if (clueNum == 4) {
			myHint.text = clueList.clue005;
		} else if (clueNum == 5) {
			myHint.text = clueList.clue006;
		} else if (clueNum == 6) {
			myHint.text = clueList.clue007;
		} else if (clueNum == 7) {
			myHint.text = clueList.clue008;
		} else if (clueNum == 8) {
			myHint.text = clueList.clue009;
		} else if (clueNum == 9) {
			myHint.text = clueList.clue010;
		} else if (clueNum == 10) {
			myHint.text = clueList.clue011;
		} else if (clueNum == 11) {
			myHint.text = clueList.clue012;
		} else if (clueNum == 12) {
			myHint.text = clueList.clue013;
		} else if (clueNum == 13) {
			myHint.text = clueList.clue014;
		} else if (clueNum == 14) {
			myHint.text = clueList.clue015;
		} else if (clueNum == 15) {
			myHint.text = clueList.clue016;
		} else if (clueNum == 16) {
			myHint.text = clueList.clue017;
		} else if (clueNum == 17) {
			myHint.text = clueList.clue018;
		} else if (clueNum == 18) {
			myHint.text = clueList.clue019;
		} else if (clueNum == 19) {
			myHint.text = clueList.clue020;
		} else if (clueNum == 20) {
			myHint.text = clueList.clue021;
		} else if (clueNum == 21) {
			myHint.text = clueList.clue022;
		} else if (clueNum == 22) {
			myHint.text = clueList.clue023;
		} else if (clueNum == 23) {
			myHint.text = clueList.clue024;
		} else if (clueNum == 24) {
			myHint.text = clueList.clue025;
		} else if (clueNum == 25) {
			myHint.text = clueList.clue026;
		} else if (clueNum == 26) {
			myHint.text = clueList.clue027;
		} else if (clueNum == 27) {
			myHint.text = clueList.clue028;
		} else if (clueNum == 28) {
			myHint.text = clueList.clue029;
		} else if (clueNum == 29) {
			myHint.text = clueList.clue030;
		} else if (clueNum == 30) {
			myHint.text = clueList.clue031;
		} else if (clueNum == 31) {
			myHint.text = clueList.clue032;
		} else if (clueNum == 32) {
			myHint.text = clueList.clue033;
		} else if (clueNum == 33) {
			myHint.text = clueList.clue034;
		} else if (clueNum == 34) {
			myHint.text = clueList.clue035;
		} else if (clueNum == 35) {
			myHint.text = clueList.clue036;
		} else if (clueNum == 36) {
			myHint.text = clueList.clue037;
		} else if (clueNum == 37) {
			myHint.text = clueList.clue038;
		} else if (clueNum == 38) {
			myHint.text = clueList.clue039;
		} else if (clueNum == 39) {
			myHint.text = clueList.clue040;
		}

		if (myHint.text == "") {
			myHint.text = clueList.clue001;
		}

		jsonHolder = jsonHolder2;
	}


	public void writeOff()
	{
		isWriting = false;
	}
	//void OnGUI()
	//{
		//GUI.Label (new Rect (10, 10, 200, 200), "Level: " + level);
		//GUI.Label (new Rect (10, 40, 200, 200), "Exp: " + exp);
		//GUI.Label (new Rect (10, 70, 200, 200), "Puzzle Pieces: " + puzzlePieces);
		//GUI.Label (new Rect (10, 100, 200, 200), "Works Collected: " + worksScanned);
	//}

	public void viewCollection()
	{
		collected = true;
	}

	public void button1()
	{
		button1on = false;
	}

	public void button2()
	{
		button2on = false;
		piece1Found = true;
		Save ();
	}

	public void button3()
	{
		button3on = false;
	}

	public void button4()
	{
		button4on = false;
		piece2Found = true;
		Save ();
	}

	public void button5()
	{
		button5on = false;
		piece3Found = true;
		Save ();
	}

	public void button6()
	{
		button6on = false;
		piece4Found = true;
		Save ();
	}

	public void button7()
	{
		button7on = false;
		piece5Found = true;
		Save ();
	}

	public void button8()
	{
		button8on = false;
		piece6Found = true;
		Save ();
	}

	public void button9()
	{
		button9on = false;
		piece7Found = true;
		Save ();
	}

	public void button10()
	{
		button10on = false;
		piece8Found = true;
		Save ();
	}

	public void button11()
	{
		button11on = false;
		piece9Found = true;
		Save ();
	}

	public void button12()
	{
		button12on = false;
		piece10Found = true;
		Save ();
	}

	public void button13()
	{
		button13on = false;
		piece11Found = true;
		Save ();
	}

	public void button14()
	{
		button14on = false;
		piece12Found = true;
		Save ();
	}

	public void button15()
	{
		button15on = false;
	}

	public void button16()
	{
		button16on = false;
	}

	public void button17()
	{
		button17on = false;
	}

	public void button18()
	{
		button18on = false;
	}

	public void button19()
	{
		button19on = false;
	}

	public void button20()
	{
		button20on = false;
	}

	public void button21()
	{
		button21on = false;
	}

	public void button22()
	{
		button22on = false;
	}

	public void button23()
	{
		button23on = false;
	}

	public void button24()
	{
		button24on = false;
	}

	public void button25()
	{
		button25on = false;
	}

	public void button26()
	{
		button26on = false;
	}

	public void button27()
	{
		button27on = false;
	}

	public void button28()
	{
		button28on = false;
	}

	public void button29()
	{
		button29on = false;
	}

	public void button30()
	{
		button30on = false;
	}

	public void button31()
	{
		button31on = false;
	}

	public void button32()
	{
		button32on = false;
	}

	public void button33()
	{
		button33on = false;
	}


	public void Save()
	{
		BinaryFormatter bf = new BinaryFormatter ();
		FileStream file = File.Create (Application.persistentDataPath + "/playerInfo.dat");

		PlayerData data = new PlayerData ();
		data.level = level;
		data.exp = exp;
		data.title = title;

		data.button1on = button1on;
		data.button2on = button2on;
		data.button3on = button3on;
		data.button4on = button4on;
		data.button5on = button5on;
		data.button6on = button6on;
		data.button7on = button7on;
		data.button8on = button8on;
		data.button9on = button9on;
		data.button10on = button10on;
		data.button11on = button11on;
		data.button12on = button12on;
		data.button13on = button13on;
		data.button14on = button14on;
		data.button15on = button15on;
		data.button16on = button16on;
		data.button17on = button17on;
		data.button18on = button18on;
		data.button19on = button19on;
		data.button20on = button20on;
		data.button21on = button21on;
		data.button22on = button22on;
		data.button23on = button23on;
		data.button24on = button24on;
		data.button25on = button25on;
		data.button26on = button26on;
		data.button27on = button27on;
		data.button28on = button28on;
		data.button29on = button29on;
		data.button30on = button30on;
		data.button31on = button31on;
		data.button32on = button32on;
		data.button33on = button33on;

		data.piece1Found = piece1Found;
		data.piece2Found = piece2Found;
		data.piece3Found = piece3Found;
		data.piece4Found = piece4Found;
		data.piece5Found = piece5Found;
		data.piece6Found = piece6Found;
		data.piece7Found = piece7Found;
		data.piece8Found = piece8Found;
		data.piece9Found = piece9Found;
		data.piece10Found = piece10Found;
		data.piece11Found = piece11Found;
		data.piece12Found = piece12Found;

		data.collected = collected;

		bf.Serialize (file, data);
		file.Close ();
	}

	public void Load()
	{
		if (File.Exists (Application.persistentDataPath + "/playerInfo.dat"))
		{
			BinaryFormatter bf = new BinaryFormatter ();
			FileStream file = File.Open (Application.persistentDataPath + "/playerInfo.dat", FileMode.Open);
			PlayerData data = (PlayerData)bf.Deserialize (file);
			file.Close ();

			level = data.level;
			exp = data.exp;
			title = data.title;

			levelText.text = "Level: " + level;
			expText.text = "100 / " + exp;
			titleText.text = title;

			button1on = data.button1on;
			button2on = data.button2on;
			button3on = data.button3on;
			button4on = data.button4on;
			button5on = data.button5on;
			button6on = data.button6on;
			button7on = data.button7on;
			button8on = data.button8on;
			button9on = data.button9on;
			button10on = data.button10on;
			button11on = data.button11on;
			button12on = data.button12on;
			button13on = data.button13on;
			button14on = data.button14on;
			button15on = data.button15on;
			button16on = data.button16on;
			button17on = data.button17on;
			button18on = data.button18on;
			button19on = data.button19on;
			button20on = data.button20on;
			button21on = data.button21on;
			button22on = data.button22on;
			button23on = data.button23on;
			button24on = data.button24on;
			button25on = data.button25on;
			button26on = data.button26on;
			button27on = data.button27on;
			button28on = data.button28on;
			button29on = data.button29on;
			button30on = data.button30on;
			button31on = data.button31on;
			button32on = data.button32on;
			button33on = data.button33on;

			piece1Found = data.piece1Found;
			piece2Found = data.piece2Found;
			piece3Found = data.piece3Found;
			piece4Found = data.piece4Found;
			piece5Found = data.piece5Found;
			piece6Found = data.piece6Found;
			piece7Found = data.piece7Found;
			piece8Found = data.piece8Found;
			piece9Found = data.piece9Found;
			piece10Found = data.piece10Found;
			piece11Found = data.piece11Found;
			piece12Found = data.piece12Found;

			collected = data.collected;
		}
	}

	public void PieceCollected()
	{
		puzzlePieces += 1;
		worksScanned += 1;
		collected = false;
		exp = exp + 75;

		if (exp >= 150)
		{
			level = level + 1;
			levelText.text = "Level: " + level;
			exp = 0;
			expText.text = "100 / " + exp;
		}

		if (level == 2) 
		{
			title = "Beginner";
			titleText.text = title;
		}

		if (level == 3) 
		{
			title = "Novice";
			titleText.text = title;
		}

		if (level == 4) 
		{
			title = "Apprentice";
			titleText.text = title;
		}

		if (level == 5) 
		{
			title = "Hobbyist";
			titleText.text = title;
		}

		if (level == 6) 
		{
			title = "Junior Collector";
			titleText.text = title;
		}

		if (level == 7) 
		{
			title = "Senior Collector";
			titleText.text = title;
		}

		if (level == 8) 
		{
			title = "Aficionado";
			titleText.text = title;
		}

		if (level == 9) 
		{
			title = "Master Collector";
			titleText.text = title;
		}

		if (level == 10) 
		{
			title = "Lord Collector";
			titleText.text = title;
		}
	}

	public void HintCollected()
	{
		//collected = false;
		worksScanned += 1;
		hintsCollected += 1;
		exp = exp + 34;
		expText.text = "100 / " + exp;


		if (exp >= 150)
		{
			level = level + 1;
			levelText.text = "Level: " + level;
			exp = 0;
			expText.text = "100 / " + exp;
		}

		if (level == 2) 
		{
			title = "Beginner";
			titleText.text = title;
		}

		if (level == 3) 
		{
			title = "Novice";
			titleText.text = title;
		}

		if (level == 4) 
		{
			title = "Apprentice";
			titleText.text = title;
		}

		if (level == 5) 
		{
			title = "Hobbyist";
			titleText.text = title;
		}

		if (level == 6) 
		{
			title = "Junior Collector";
			titleText.text = title;
		}

		if (level == 7) 
		{
			title = "Senior Collector";
			titleText.text = title;
		}

		if (level == 8) 
		{
			title = "Aficionado";
			titleText.text = title;
		}

		if (level == 9) 
		{
			title = "Master Collector";
			titleText.text = title;
		}

		if (level == 10) 
		{
			title = "Lord Collector";
			titleText.text = title;
		}
	}



}

[Serializable]
class PlayerData
{
	public int level;
	public int exp;
	public string title;

	public bool piece1Found;
	public bool piece2Found;
	public bool piece3Found;
	public bool piece4Found;
	public bool piece5Found;
	public bool piece6Found;
	public bool piece7Found;
	public bool piece8Found;
	public bool piece9Found;
	public bool piece10Found;
	public bool piece11Found;
	public bool piece12Found;
	public bool piece13Found;
	public bool piece14Found;
	public bool piece15Found;

	public bool collected;

	public bool button1on;
	public bool button2on;
	public bool button3on;
	public bool button4on;
	public bool button5on;
	public bool button6on;
	public bool button7on;
	public bool button8on;
	public bool button9on;
	public bool button10on;
	public bool button11on;
	public bool button12on;
	public bool button13on;
	public bool button14on;
	public bool button15on;
	public bool button16on;
	public bool button17on;
	public bool button18on;
	public bool button19on;
	public bool button20on;
	public bool button21on;
	public bool button22on;
	public bool button23on;
	public bool button24on;
	public bool button25on;
	public bool button26on;
	public bool button27on;
	public bool button28on;
	public bool button29on;
	public bool button30on;
	public bool button31on;
	public bool button32on;
	public bool button33on;

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
}