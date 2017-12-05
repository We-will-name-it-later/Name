using UnityEngine;

public class MultiButton : MonoBehaviour {

	bool isPaused = false;
	public GameObject panel;

	public void UnPause()
	{
		Time.timeScale = 1f;
		isPaused = false;
	}

	private void Update()
	{
		panel.SetActive(isPaused);
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			isPaused = !isPaused;

			if (isPaused)
				Time.timeScale = 0f;

			if (!isPaused)
				Time.timeScale = 1f;
		}
	}
}
