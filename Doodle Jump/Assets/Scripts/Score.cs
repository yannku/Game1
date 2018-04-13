using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public Transform player;
	public Text scoreText;
	
	private float score;
	
	// Update is called once per frame
	//setting the score arrording to the position of the player(each time the player goes up score increases)
	void Update () {

		if(player.position.y >= score){
			score= player.position.y;
		}
		
		scoreText.text = score.ToString("0");
	}
}
