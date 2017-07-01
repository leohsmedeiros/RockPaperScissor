using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum ScreenName { ScreenGameModeMenu, ScreenGame }

public class ChangeScreen : MonoBehaviour, IChangeScreen {

	public List<GameObject> Screens;

	public void ShowScreen (ScreenName screen)
	{
		Screens.ForEach (x => x.SetActive (x.name.Equals (screen.ToString ())));
	}
}
