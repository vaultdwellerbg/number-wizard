using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
	[SerializeField] int max = 1000;
	[SerializeField] int min = 1;
	[SerializeField] TextMeshProUGUI guessText;
	int guess;

	void Start()
	{
		UpdateGuess();
	}

	public void OnPressHigher() 
	{
		min = guess + 1;
		UpdateGuess();
	}

	public void OnPressLower() 
	{
		max = guess - 1;
		UpdateGuess();
	}

	void UpdateGuess() 
	{
		guess = Random.Range(min, max + 1);
		guessText.text = guess.ToString();
	}
}
