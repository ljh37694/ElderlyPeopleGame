using UnityEngine;

public class SpawnPoint : MonoBehaviour {
	const float RESPAWNWAITINGTIME = 2f;

	float time;
	bool isReady;

	void Awake() {
		time = 0f;
		isReady = true;
	}

	void Update() {
		if (isReady == false) {
			time += Time.deltaTime;

			if (time >= RESPAWNWAITINGTIME) {
				isReady = true;
				time = 0f;
			}
		}
	}

	public bool getReady() { return isReady; }
	public void setReady(bool ready) { isReady = ready; }
}
