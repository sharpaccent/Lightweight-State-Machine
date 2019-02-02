using UnityEngine;
using System.Collections;

namespace SA
{
	public class SecondAction : StateAction
	{
		public override bool Execute()
		{
			Debug.Log("this is the second action");

			return false;
		}
	}
}
