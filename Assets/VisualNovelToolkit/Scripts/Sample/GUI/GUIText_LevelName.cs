//_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/.
// 			VisualNovelToolkit		     /_/_/_/_/_/_/_/_/_/.
// Copyright ©2013 - Sol-tribe.	/_/_/_/_/_/_/_/_/_/.
//_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/_/.
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

/// <summary>
/// Show GUI text_ level name at the top of left corner.
/// </summary>
public class GUIText_LevelName : MonoBehaviour {

	// Use this for initialization
	void Start () {
		if( GetComponent<Text>() != null ){	
			SetCurrentLevelName();
		}
	}
	
	void Update(){
		if(GetComponent<Text>() != null ){	
			if( string.IsNullOrEmpty(GetComponent<Text>().text ) || GetComponent<Text>().text != Application.loadedLevelName  ){	
				SetCurrentLevelName();
			}
		}
	}
	
	void SetCurrentLevelName( ){
		GetComponent<Text>().text = Application.loadedLevelName;			
	}
}
