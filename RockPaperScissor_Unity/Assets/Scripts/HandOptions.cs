using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandOptions {

	public string Id { private set; get; }
	public Sprite Image { private set; get; }
	public List<HandOptions> Win { private set; get; }

	public HandOptions (string id, Sprite image)
	{
		Id = id;
		Image = image;
		Win = new List<HandOptions> ();
	}

	public void SetWinList (List<HandOptions> win)
	{
		Win = win;
	}

	public bool CheckIfCanBeat (HandOptions handOption)
	{
		return (Win.Find (x => x.Id.Equals (handOption.Id)) != null);
	}
}
