using UnityEngine;

public class SpawnBird : MonoBehaviour {
	public Transform[] spawnPoint;

	GameObject[] birds;
	float timer;

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

		spawnBird();
	}

	void Update() {
		timer += Time.deltaTime;

		float spawnInterval = Random.Range(1, 4);

        if (!GameManager.instance.player.isGameOver() && timer > spawnInterval) {
			timer = 0f;

			spawnBird();
		}
    }

	void spawnBird() {
		int idx;

		// Bird가 모두 활성화 상태일 때 무한 루프를 방지하기 위해서 for문 사용
		for (int i = 0; i < 400; i++) {
			idx = Random.Range(1, spawnPoint.Length);

			if (!birds[idx].activeSelf) {
				birds[idx].SetActive(true);

				break;
			}
		}
	}
}
