using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour 
{
	[SerializeField] Text pointsText;
	Text text;
	int score, round;

	void Awake()
	{
		text = GetComponent<Text>();
	}
	void OnGUI()
	{
		text.text = string.Format("Score: {0}  Round: {1}", score, round);
	}

	public void AddScore(int points)
	{
		score += points;
		StartCoroutine("ScoreText", points);
	}

	IEnumerator ScoreText(int points)
	{
		pointsText.gameObject.SetActive(true);
		pointsText.text = ""+points;
		yield return new WaitForSeconds(1f);
		pointsText.gameObject.SetActive(false);
	}

}
