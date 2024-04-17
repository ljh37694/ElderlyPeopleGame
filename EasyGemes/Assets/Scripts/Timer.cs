using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour {
	float time;
	public TMP_Text timeText;
	public GameObject gameOverPanel;

	void Awake() {
		time = 30f;
		timeText = GetComponent<TMP_Text>();
    }

    void Update() {
		if (time > 0f) {
			time -= Time.deltaTime;

			int minute = (int)time / 60, second = (int)time % 60;

			timeText.text = minute.ToString("00") + ":" + second.ToString("00");
		}

		else {
			GameManager.instance.player.setGameOver(true);

			if (!gameOverPanel.activeSelf)
				GameManager.instance.sound.playGameClearSound();
			gameOverPanel.SetActive(true);
		}
    }
}
