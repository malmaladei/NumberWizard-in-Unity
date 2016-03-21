using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string name){
		Debug.Log("Level load requested for: " + name);
		Application.LoadLevel(name);
	}
	
	public void BackToStart(){
		Debug.Log("User wants to go back to home menu");
		Application.LoadLevel("Start");
	}
		
	public void QuitRequest(){
		Debug.Log("Game Quit requested");
		Application.Quit();
	}
}
