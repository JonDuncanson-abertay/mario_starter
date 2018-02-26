using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameLogic : MonoBehaviour {

	Player playerComponent;

	public bool gameOver = false; // is the game over?

    public int Score;

    public float LevelTime;

	// Use this for initialization
	void Start () {
		// find the player component
		playerComponent = GameObject.FindGameObjectWithTag ("Player").GetComponent<Player> ();

        Score = 0;

        LevelTime = 120;
	}
	
	// Update is called once per frame
	void Update () {
        // decrement the timer?
        LevelTime -= Time.deltaTime;

        if (LevelTime <= 0)
        {
            gameOver = true;
        }

        // if the player number of lives is zero, game over
        if (playerComponent.Lives == 0) {
			gameOver = true;

			// pause the game
			Time.timeScale = 0.0f;            
		}
	}
}
