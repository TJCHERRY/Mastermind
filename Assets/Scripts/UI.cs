using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class UI : MonoBehaviour {

	// Use this for initialization
	public void GotoScene(){

		SceneManager.LoadScene("AI");


	}

	public void Quit(){
	
		Application.Quit ();
	}

	public void Retry(){
	
		SceneManager.LoadScene ("AI");
	
	}
}
