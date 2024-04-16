using TMPro;
using UnityEngine;

public class StopWatch : MonoBehaviour {
	public float time;
	public TMP_Text timeText;

    void Awake() {
		time = 0f;
    }

    void Update() {
		time += Time.deltaTime;

		int minute = (int)time / 60, second = (int)time % 60;

		timeText.text = minute.ToString("00") + ":" + second.ToString("00");
    }
}
