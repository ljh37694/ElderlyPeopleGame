using UnityEngine;

public class Birds : MonoBehaviour {
	float time;
	const float ACTIVETIME = 5f;

	void Awake() {
		time = 0f;
	}

	void Update() {
		if (gameObject.activeSelf) { 
			time += Time.deltaTime;
		}

		if (time >= ACTIVETIME) {
			gameObject.SetActive(false);
			time = 0f;
		}
	}

	void OnMouseEnter() {
		if (!GameManager.instance.player.isGameOver()) {
			gameObject.SetActive(false);
			GameManager.instance.sound.playShotSound();
			time = 0f;
			GameManager.instance.score.PlusScore(100);
		}
	}
}
