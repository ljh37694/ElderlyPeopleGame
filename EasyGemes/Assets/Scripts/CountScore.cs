using TMPro;
using UnityEngine;

public class CountScore : MonoBehaviour {
	int score;
	public TMP_Text scoreText;

	void Awake() {
		score = 0;
	}

	public void plusScore(int plusScore) {
		score += plusScore;
		scoreText.text = "����: " + score.ToString();
	}

	public int getScore() { return score; }
}
