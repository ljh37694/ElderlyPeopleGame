using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {
	public GameObject gameOverPanel;

	public void gameRestart() {
		gameOverPanel.SetActive(false);
		SceneManager.LoadSceneAsync("CatchBird");
	}
}
