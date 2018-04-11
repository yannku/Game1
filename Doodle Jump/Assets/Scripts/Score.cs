using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public Transform player;
	public Text scoreText;
	
	private float score;
	
	// Update is called once per frame
	void Update () {

		if(player.position.y >= score){
			score= player.position.y;
		}
		
		scoreText.text = score.ToString("0");
	}
}
