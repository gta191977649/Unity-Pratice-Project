using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	bool gameHasEnd = false;
	public void gameOver() {
		if(gameHasEnd) {
			gameHasEnd = true;
			Debug.Log("Game Over");
			restart();
		}
	}
	void restart() {
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
}
