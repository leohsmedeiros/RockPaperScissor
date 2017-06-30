using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScreen : MonoBehaviour {

	public enum ScreenName { ScreenGameModeMenu, ScreenGame }
	public List<GameObject> Screens;


	public void ShowScreen (ScreenName screen)
	{
		Screens.ForEach (x => x.SetActive (x.name.Equals (screen.ToString ())));
	}
}
