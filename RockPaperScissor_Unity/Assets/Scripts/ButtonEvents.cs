using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ChangeScreen))]
public class ButtonEvents : MonoBehaviour {

	public GameController GameCtrl;
	IChangeScreen ScreenChanger;

	void Start ()
	{
		ScreenChanger = this.GetComponent<IChangeScreen> ();
	}

	public void OnButtonPlayerVsCPU ()
	{
		GameCtrl.ChangeGameMode (GameController.GameModes.Player_CPU, GameCtrl.PlayerNameInput.text);
		ScreenChanger.ShowScreen (ScreenName.ScreenGame);
	}

	public void OnButtonCPUVsCPU ()
	{
		GameCtrl.ChangeGameMode (GameController.GameModes.CPU_CPU, "CPU");
		ScreenChanger.ShowScreen (ScreenName.ScreenGame);
	}

	public void OnButtonReturn ()
	{
		ScreenChanger.ShowScreen (ScreenName.ScreenGameModeMenu);
	}

	public void OnButtonNextMatch ()
	{
		GameCtrl.NextMatch ();
	}

	public void OnButtonChooseHandOption (string HandId)
	{
		GameCtrl.SetPlayerChoice (HandId);
	}

}
