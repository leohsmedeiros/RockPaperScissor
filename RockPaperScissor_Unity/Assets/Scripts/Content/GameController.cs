using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

	public enum GameModes { Player_CPU, CPU_CPU }

	[HideInInspector]
	public GameModes CurGameMode;
	public ChangeScreen ScreenChanger;
	public InputField PlayerNameInput;
	public Text PlayerNameText;

	public HandsRepository repository;

	public GameObject OptionsBoard;
	public GameObject ResultBoard;

	public Image LeftImage;
	public Image RightImage;

	HandOptions Player1_Hand;
	HandOptions Player2_Hand;

	public Text ScoreBoard;

	int ScorePlayer1;
	int ScorePlayer2;

	public void ChangeGameMode (GameModes NewGameMode, string playerName)
	{
		ScorePlayer1 = 0;
		ScorePlayer2 = 0;

		CurGameMode = NewGameMode;
		PlayerNameText.text = playerName.Equals (string.Empty) ? "Player" : playerName;
		NextMatch ();
	}

	public void SetPlayerChoice (string PlayerChoiceId)
	{
		Player1_Hand = repository.Find (PlayerChoiceId);
		ShowResult ();
	}
		
	public void NextMatch ()
	{
		Player2_Hand = repository.SelectRandom ();

		if (CurGameMode == GameModes.Player_CPU) {
			ShowOptions ();
		} else {
			Player1_Hand = repository.SelectRandom ();
			ShowResult ();	
		}			
	}

	void ShowResult ()
	{
		ScorePlayer1 = Player1_Hand.CheckIfCanBeat (Player2_Hand) ? ScorePlayer1 + 1 : ScorePlayer1;
		ScorePlayer2 = Player2_Hand.CheckIfCanBeat (Player1_Hand) ? ScorePlayer2 + 1 : ScorePlayer2;

		ScoreBoard.text = "<color=green>" + ScorePlayer1.ToString () + "</color> x <color=red>" + ScorePlayer2.ToString () + "</color>";

		LeftImage.sprite = Player1_Hand.Image;
		RightImage.sprite = Player2_Hand.Image;

		OptionsBoard.SetActive (false);
		ResultBoard.SetActive (true);
	}

	void ShowOptions ()
	{
		OptionsBoard.SetActive (true);
		ResultBoard.SetActive (false);
	}
}
