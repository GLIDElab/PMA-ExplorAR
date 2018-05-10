using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DatabaseController : MonoBehaviour
{
    public GameObject database;
    public GameObject exhibitDisplay;
    public Button[] exhibits;
    public Sprite[] picture;

    public Text title_header;
    public Text title_artist;
    public Text description;
    public Image displayedPainting;
    public Text yearCreated;
    private int year;

	public GameObject originalButtonGO;
	public Button originalButton;
	public Transform buttonParent;

	public JSONWriter json;

    //Record where we started touching the screen.
    private Vector2 touchOrigin = -Vector2.one;
    

	// Use this for initialization
	void Start ()
    {
        database.SetActive(true);
        exhibitDisplay.SetActive(false);
        exhibits = this.GetComponentsInChildren<Button>();
        Debug.Log("Number of exhibits: " + exhibits.Length);
    }
	
	// Update is called once per frame
	void Update ()
    {
        if(Input.touchCount > 0)
        {
            Touch myTouch = Input.touches[0];
            if(myTouch.phase == TouchPhase.Began)
            {
                touchOrigin = myTouch.position;
            }
        }
    }

    public void toExhibit(Button btn)
    {
		title_header.text = "Gallery 161";

		exhibitDisplay.SetActive(true);
		json.currWork = JSONWriter.ExtractJSONFile (json.gallery161_003);
		json.WriteStats (json.currWork);
    }

    public void toDatabase()
    {
        database.SetActive(true);
        exhibitDisplay.SetActive(false);
    }

    public void toMainScreen()
    {
        Application.LoadLevel(1);
    }

	public void CreateButton () {
		if (originalButtonGO.activeSelf) {
			Button buttonCopy = Instantiate<Button> (originalButton, buttonParent);
		} else {
			originalButtonGO.SetActive (true);
		}
	}

}
	
//        //Set text and image based on what button you pressed.
//        if(btn == exhibits[0])
//        {
//            title_header.text = "Exhibit 1";
//            title_artist.text = "Exhibit 1 - Artist 1";
//            description.text = "This Exhibit #1. Description goes here.";
//            displayedPainting.sprite = picture[0];
//            year = 2000;
//        }
//        if (btn == exhibits[1])
//        {
//            title_header.text = "Exhibit 2";
//            title_artist.text = "Exhibit 2 - Artist 2";
//            description.text = "This Exhibit #2. Description goes here.";
//            displayedPainting.sprite = picture[1];
//            year = 2012;
//        }
//        if (btn == exhibits[2])
//        {
//            title_header.text = "Exhibit 3";
//            title_artist.text = "Exhibit 3 - Artist 3";
//            description.text = "This Exhibit #3. Description goes here.";
//            displayedPainting.sprite = picture[2];
//            year = 1629;
//        }
//        if (btn == exhibits[3])
//        {
//            title_header.text = "Exhibit 4";
//            title_artist.text = "Exhibit 4 - Artist 4";
//            description.text = "This Exhibit #4. Description goes here.";
//            displayedPainting.sprite = picture[3];
//            year = 1738;
//        }
//        if (btn == exhibits[4])
//        {
//            title_header.text = "Exhibit 5";
//            title_artist.text = "Exhibit 5 - Artist 5";
//
//            description.text = "This Exhibit #5. Description goes here.";
//            displayedPainting.sprite = picture[4];
//            year = 1950;
//        }
//        if (btn == exhibits[5])
//        {
//            title_header.text = "Exhibit 6";
//            title_artist.text = "Exhibit 6 - Artist 6";
//
//            description.text = "This Exhibit #6. Description goes here.";
//            displayedPainting.sprite = picture[5];
//            year = 1950;
//        }
//        if (btn == exhibits[6])
//        {
//            title_header.text = "Exhibit 7";
//            title_artist.text = "Exhibit 7 - Artist 7";
//
//            description.text = "This Exhibit #7. Description goes here.";
//            displayedPainting.sprite = picture[6];
//            year = 1950;
//        }
//        if (btn == exhibits[7])
//        {
//            title_header.text = "Exhibit 8";
//            title_artist.text = "Exhibit 8 - Artist 8";
//
//            description.text = "This Exhibit #8. Description goes here.";
//            displayedPainting.sprite = picture[7];
//            year = 1950;
//        }
//        if (btn == exhibits[8])
//        {
//            title_header.text = "Exhibit 9";
//            title_artist.text = "Exhibit 9 - Artist 9";
//
//            description.text = "This Exhibit #9. Description goes here.";
//            displayedPainting.sprite = picture[8];
//            year = 1950;
//        }
//        if (btn == exhibits[9])
//        {
//            title_header.text = "Exhibit 10";
//            title_artist.text = "Exhibit 10 - Artist 10";
//
//            description.text = "This Exhibit #10. Description goes here.";
//            displayedPainting.sprite = picture[9];
//            year = 1950;
//        }
//        yearCreated.text = "Year Painted: " + year;
//        database.SetActive(false);
//        exhibitDisplay.SetActive(true);
