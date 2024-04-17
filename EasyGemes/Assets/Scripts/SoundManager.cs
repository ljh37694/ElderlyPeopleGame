using UnityEngine;

public class SoundManager : MonoBehaviour {
	AudioSource audioSource;
	public AudioClip shotSound;

	void Awake() {
		audioSource = GetComponent<AudioSource>();
	}

	public void playShotSound() {
		audioSource.PlayOneShot(shotSound);
	}
}
