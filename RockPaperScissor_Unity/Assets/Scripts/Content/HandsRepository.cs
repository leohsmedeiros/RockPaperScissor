using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandsRepository : MonoBehaviour {

	List<HandOptions> Hands;
	public List<Sprite> Images;

	void Start () {
		Hands = new List<HandOptions> ();

		HandOptions Rock, Paper, Scissor;

		Rock = new HandOptions ("Rock", Images.Find (x => x.name.Equals ("Rock")));
		Paper = new HandOptions ("Paper", Images.Find (x => x.name.Equals ("Paper")));
		Scissor = new HandOptions ("Scissor", Images.Find (x => x.name.Equals ("Scissor")));

		Rock.SetWinList (new List<HandOptions> () { Scissor });
		Paper.SetWinList (new List<HandOptions> () { Rock });
		Scissor.SetWinList (new List<HandOptions> () { Paper });

		Hands.Add (Rock);
		Hands.Add (Paper);
		Hands.Add (Scissor);

	}

	public HandOptions Find (string HandId)
	{
		return Hands.Find (x => x.Id.Equals (HandId));
	}

	public HandOptions SelectRandom ()
	{
		return Hands [Random.Range (0, Hands.Count)];
	}

}
