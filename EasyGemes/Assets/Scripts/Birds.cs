using UnityEngine;

public class Birds : MonoBehaviour {
	float time;
	const float ACTIVETIME = 5f;
	AudioSource audioSource;
	public AudioClip shotSound;

	void Awake() {
		time = 0f;
		audioSource = GetComponent<AudioSource>();
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
			audioSource.PlayOneShot(shotSound);

			gameObject.SetActive(false);
			time = 0f;
			GameManager.instance.score.PlusScore(100);
		}
	}
}
