using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {
	public GameObject gameOverPanel;
	public TMP_Text endScore;

	void Update() {
		endScore.text = GameManager.instance.score.getScore().ToString() + "Á¡";
	}

	public void gameRestart() {
		gameOverPanel.SetActive(false);
		SceneManager.LoadSceneAsync("CatchBird");
	}
}
