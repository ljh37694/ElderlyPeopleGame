using UnityEngine;

public class SpawnBird : MonoBehaviour {
	public Transform[] spawnPoint;

	GameObject[] birds;
	float timer;
	const float SPAWNINTERVAL = 5f;

	void Awake() {
		spawnPoint = GetComponentsInChildren<Transform>();
		timer = 0f;

		birds = new GameObject[spawnPoint.Length];

		for (int i = 1; i < spawnPoint.Length; i++) {
			GameObject bird = GameManager.instance.pool.GetPrefab(Random.Range(0, 3));

			bird.SetActive(false);
			birds[i] = bird;
			birds[i].transform.position = spawnPoint[i].position;
		}
	}

	void Update() {
		timer += Time.deltaTime;

        if (timer > SPAWNINTERVAL) {
			timer = 0f;

			int idx;

			while (true) {
				idx = Random.Range(1, spawnPoint.Length);

				if (!birds[idx].activeSelf) {
					birds[idx].SetActive(true);

					break;
				}
			}
		}
    }
}
