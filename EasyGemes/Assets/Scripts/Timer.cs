using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour {
	float time;
	public TMP_Text timeText;

    void Awake() {
		time = 60f;
		timeText = GetComponent<TMP_Text>();
    }

    void Update() {
		if (time <= 0f) {

		} 

		else {
			time -= Time.deltaTime;

			int minute = (int)time / 60, second = (int)time % 60;

			timeText.text = minute.ToString("00") + ":" + second.ToString("00");
		}
    }
}
