using TMPro;
using UnityEngine;

public class Birds : MonoBehaviour {
	void OnMouseEnter() {
		gameObject.SetActive(false);

		GameManager.instance.score.PlusScore(100);
	}
}
