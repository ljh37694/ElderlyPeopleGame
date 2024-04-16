using TMPro;
using UnityEngine;

public class Birds : MonoBehaviour {
	void OnMouseEnter() {
		if (!GameManager.instance.player.isGameOver()) {
			gameObject.SetActive(false);

			GameManager.instance.score.PlusScore(100);
		}
	}
}
