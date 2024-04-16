using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour {
	public void GameStartBtn() {
		SceneManager.LoadSceneAsync("CatchBird");
		//SceneManager.UnloadScene();
	}
}
