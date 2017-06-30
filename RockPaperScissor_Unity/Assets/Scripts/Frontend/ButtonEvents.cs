using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonEvents : MonoBehaviour {

	public GameController GameCtrl;

	public void OnButtonPlayerVsCPU ()
	{
		GameCtrl.ChangeGameMode (GameController.GameModes.Player_CPU, GameCtrl.PlayerNameInput.text);
		GameCtrl.ScreenChanger.ShowScreen (ChangeScreen.ScreenName.ScreenGame);
	}

	public void OnButtonCPUVsCPU ()
	{
		GameCtrl.ChangeGameMode (GameController.GameModes.CPU_CPU, "CPU");
		GameCtrl.ScreenChanger.ShowScreen (ChangeScreen.ScreenName.ScreenGame);
	}

	public void OnButtonReturn ()
	{
		GameCtrl.ScreenChanger.ShowScreen (ChangeScreen.ScreenName.ScreenGameModeMenu);
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
