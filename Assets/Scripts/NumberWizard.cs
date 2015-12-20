using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {
	int max = 1000;
	int min = 1;
	int guess = 500;
	
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
		
		int pmax = max;
		max = max + 1;
		
		print ("================================");
		print ("Welcome to NumberWizard!");
		print ("Pick a number in your head, but don't tell it to me!");
		
		print ("The highest number you can pick is " + pmax + ".");
		print ("The lowest number you can pick is " + min + ".");
		
		print ("Is the number higher than " + guess + "?");
		print ("Up arrow for higher, down for lower, enter for equal.");
	}
	
	void NextGuess () {
		guess = (max + min) / 2;
		print ("Is it higher or lower than " + guess + "?");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			print ("Sounds like it's higher!");
			min = guess;
			NextGuess ();
		} 
		else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			print ("Sounds like it's lower!");
			max = guess;
			NextGuess (); 
		}
		else if (Input.GetKeyDown (KeyCode.Return)) {
			print ("I won!");
			StartGame ();
		}	
	}
}
