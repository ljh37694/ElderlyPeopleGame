using UnityEngine;

public class GameManager : MonoBehaviour {
	public static GameManager instance;

	public Player player;
	public PoolManager pool;
	public CountScore score;

	void Awake() {
		instance = this;
	}
}
