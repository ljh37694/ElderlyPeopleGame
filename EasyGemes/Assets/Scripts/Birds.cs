using UnityEngine;

public class Birds : MonoBehaviour {
	const float ACTIVETIME = 5f;

	float time;

	void Awake() {
		init();
	}

	void Update() {
		time += Time.deltaTime;

		if (time >= ACTIVETIME) {
			birdRunAway();
		}
	}

	void OnMouseEnter() {
		if (!GameManager.instance.player.isGameOver() && gameObject.activeSelf) {
			birdDead();
		}
	}

	void init() {
		time = 0f;
		gameObject.SetActive(false);
	}

	void birdDead() {
		init();
		GameManager.instance.sound.playShotSound();
		GameManager.instance.score.plusScore(100);
	}

	void birdRunAway() {
		init();
	}
}
