using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ServerHandler : MonoBehaviour {

	// Use this for initialization
	void Start () {
		PhotonNetwork.ConnectUsingSettings ("v1.0");
	}

	void OnJoinedLobby () {
		Debug.Log ("Joined");
		PhotonNetwork.JoinRandomRoom ();
	}

	void OnPhotonRandomJoinFailed () {
		Debug.Log ("Join failed.");
		RoomOptions options = new RoomOptions () { IsVisible = true, MaxPlayers = 20 };
		int randomNum = Random.Range (0, 100000);

		PhotonNetwork.CreateRoom (randomNum.ToString(), options, TypedLobby.Default);
	}

	void OnJoinedRoom () {
		Debug.Log ("Joined Room");
	}


}
