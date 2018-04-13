using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour {
	//loads the Game Scene
	public void RestartGame()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -1);
	}
	//loads the Menu Scene
	public void Menu()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -2);
	}
}
