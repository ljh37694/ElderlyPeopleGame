using UnityEngine;

public class GameManager : MonoBehaviour {
	public static GameManager instance;

	public Player player;
	public PoolManager pool;
	public CountScore score;
	public SoundManager sound;

	void Awake() {
		instance = this;
	}
}
