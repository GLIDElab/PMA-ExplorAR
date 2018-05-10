using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClueSending : Photon.MonoBehaviour {

	public GameControl controller;

	public int testInt = 0;
	public bool isSubmitting;

	public Text userInput;
	public Text currClue;
	public string clue;

	public bool setClue;

//	#region IPunObservable implementation
//	void IPunObservable.OnPhotonSerializeView (PhotonStream stream, PhotonMessageInfo info) {
//		if (stream.isWriting) {
//			stream.SendNext (isSubmitting);
//		} else {
//			this.isSubmitting = (bool)stream.ReceiveNext ();
//		}
//	}
//	#endregion

	void Start()
	{
		controller = GameObject.FindWithTag ("Controller").GetComponent<GameControl>();
	}

	void Update()
	{
		if (controller.button1on == false) 
		{
			setClue = true;
		}
	}

	[PunRPC]
	public void SubmitClue (string clue) {
		clue = userInput.text;
		currClue.text = clue;
	}

	[PunRPC]
	public void UpdateClue (string clue) {
		controller.clue1 = clue;
	}

	public void ClueButton () {
		clue = userInput.text;
		photonView.RPC ("SubmitClue", PhotonTargets.All, clue);
	}

	public void CurrUpdate () {
		Debug.Log ("Hello, working");
		photonView.RPC ("UpdateClue", PhotonTargets.All, clue);
	}
//
//	public virtual void UpdateAllGameStates() {
//		Room room;
//		if (GameCache.Instance.TryGetRoomWithoutReference (gameId, out room)) {
//			room.EnqueueMessage (new RoomMessage ((byte)GameMessageCodes.ReinitializeGameStateOnMaster));
//		}
//	}

//	void GameLoop () {
//		while (!shouldExit) {
//			this.Service ();
//		}
//	}

//	public override void OnEvent(EventData photonEvent) {
//		base.OnEvent (photonEvent);
//		switch (photonEvent.Code) {
//		case 1:
//			testInt = 1;
//			break;
//		case 2:
//			testInt = 2;
//			break;
//		}
//	}
}
