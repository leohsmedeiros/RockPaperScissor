using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IHandsRepository {

	HandOptions Find (string HandId);
	HandOptions SelectRandom ();

}
