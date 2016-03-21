using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {
	int max = 1000;
	int min = 1;
	int guess = 500;
	int guessMax = 10;
	
	public Text currentGuess;
	
	// Use this for initialization
	void Start () {
		StartGame ();
	}

	void ResetNumbers () {
		max = 1000;
		min = 1;
		guess = 500;
	}
	
	void StartGame () {
		ResetNumbers ();
		max = max + 1;
	}
	
	void NextGuess () {
		guess = (max + min) / 2;
		Debug.Log(guess);
		currentGuess.text = guess.ToString();
		guessMax = guessMax - 1;
		if(guessMax == 0) {
			Application.LoadLevel("Win");
		}
	}

	public void GuessHigher() {
		min = guess;
		NextGuess();	
	}
	
	public void GuessLower() {
		max = guess;
		NextGuess();
	}
	
	public void Winning() {
		Application.LoadLevel("Lose");
	}
}
