using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour {

	public JSONWriter jsonData;

	public Text button;
	public string objectID;
	public Image buttonThumbnail;
	public Sprite buttonImage;

	void Start () {
		jsonData.currWork = JSONWriter.ExtractJSONFile (jsonData.gallery161_003);

		button.text = jsonData.currWork.name;
	}


}
