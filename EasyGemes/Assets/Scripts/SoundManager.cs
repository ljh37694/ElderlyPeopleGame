using UnityEngine;

public class SoundManager : MonoBehaviour {
	AudioSource audioSource;
	public AudioClip shotSound;
	public AudioClip gameClearSound;

	void Awake() {
		audioSource = GetComponent<AudioSource>();
	}

	public void playShotSound() {
		audioSource.PlayOneShot(shotSound);
	}

	public void playGameClearSound() {
		audioSource.PlayOneShot(gameClearSound);
	}
}
