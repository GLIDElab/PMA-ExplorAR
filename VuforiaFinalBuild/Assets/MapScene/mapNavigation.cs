using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mapNavigation : MonoBehaviour
{
    private int floor;

    public Sprite[] maps;
    public Sprite[] legends;

    public Image displayedMap;
    public Image displayedLegend;
    public Text floorNumber;

    public Dropdown filter;

	// Use this for initialization
	void Start ()
    {
        filter.value = 0;
        floor = 1;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(filter.value == 0)
        {
            displayedMap.sprite = maps[0];
            displayedLegend.sprite = legends[0];
            floor = 1;
        }

        if (filter.value == 1)
        {
            displayedMap.sprite = maps[1];
            displayedLegend.sprite = legends[1];
            floor = 2;
        }

        floorNumber.text = "Floor " + floor;
	}

    public void toMainScreen()
    {
        Application.LoadLevel(1);
    }
}
