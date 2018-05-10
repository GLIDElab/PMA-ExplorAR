using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class profileMenu : MonoBehaviour
{
    public Text profileName;

    private int level;
    public Text rankName;

    public Slider xpMeter;
    private int currentXP;
    private int requiredXP;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void showStats()
    {
        Debug.Log("Show stats.");
    }

    public void toMainScreen()
    {
        Application.LoadLevel(1);
    }
}
