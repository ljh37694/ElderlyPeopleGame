using TMPro;
using UnityEngine;

public class CountScore : MonoBehaviour {
	int score;
	public TMP_Text scoreText;

	void Awake() {
		score = 0;
	}

	public void PlusScore(int plusScore) {
		score += plusScore;
		scoreText.text = "Á¡¼ö: " + score.ToString();
	}
}
