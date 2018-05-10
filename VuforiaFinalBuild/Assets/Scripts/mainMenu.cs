using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainMenu : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void toDatabase()
    {
        Application.LoadLevel(2);
    }

    public void toProfileScreen()
    {
        Application.LoadLevel(3);
    }

    public void toHelpScreen()
    {
        Debug.Log("Go to Help Screen");
    }

    public void toPuzzleScreen()
    {
        Debug.Log("Go to Puzzle Screen.");
    }

    public void toMap()
    {
        Debug.Log("Go to Map.");
    }

    public void toHintScreen()
    {
        Debug.Log("Go to Hint Screen.");
    }
}
