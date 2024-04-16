using UnityEngine;

public class Player : MonoBehaviour {
	bool gameOver;

	void Awake() {
		gameOver = false;
	}

	public bool isGameOver() { return gameOver; }
	public void setGameOver(bool gameOver) { this.gameOver = gameOver; }
}
