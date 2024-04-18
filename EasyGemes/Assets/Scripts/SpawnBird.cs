using UnityEngine;

public class SpawnBird : MonoBehaviour {
	public Transform[] spawnPoints;

	GameObject[] birds;
	float timer;

	void Awake() {
		spawnPoints = GetComponentsInChildren<Transform>();
		timer = 0f;

		birds = new GameObject[spawnPoints.Length - 1];

		Debug.Log(spawnPoints.Length);

		for (int i = 0; i < spawnPoints.Length - 1; i++) {
			GameObject bird = GameManager.instance.pool.GetPrefab(Random.Range(0, 3));

			bird.SetActive(false);
			birds[i] = bird;
			birds[i].transform.position = spawnPoints[i].position;
		}

		spawnBird();
	}

	void Update() {
		timer += Time.deltaTime;

		float spawnInterval = Random.Range(0.5f, 4);

        if (!GameManager.instance.player.isGameOver() && timer > spawnInterval) {
			timer = 0f;

			spawnBird();
		}

		if (GameManager.instance.player.isGameOver()) {
			allBirdDead();
		}
    }

	void spawnBird() {
		int idx;

		// Bird가 모두 활성화 상태일 때 무한 루프를 방지하기 위해서 for문 사용
		for (int i = 0; i < 400; i++) {
			idx = Random.Range(1, birds.Length);
			SpawnPoint sp = spawnPoints[idx].GetComponent<SpawnPoint>();

			if (sp.getReady() && !birds[idx].activeSelf) {
				birds[idx].SetActive(true);
				sp.setReady(false);

				break;
			}
		}
	}

	void allBirdDead() {
		foreach(GameObject bird in birds) {
			if (bird.activeSelf)
				bird.SetActive(false);
		}
	}
}
