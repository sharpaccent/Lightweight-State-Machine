using UnityEngine;
using System.Collections;

namespace SA
{
	public class InputManager : StateAction
	{
		PlayerStatesManager states;
		string targetState;

		public InputManager(PlayerStatesManager playerStatesManager, string targetState)
		{
			states = playerStatesManager;
			this.targetState = targetState;
		}

		public override bool Execute()
		{
			states.horizontal = Input.GetAxis("Horizontal");
			states.vertical = Input.GetAxis("Vertical");

			Debug.Log("This is in the locomotion state");

			if (Input.GetKeyDown(KeyCode.Space))
			{
				states.SetState(targetState);
				return true;
			}

			return false;
		}
	}
}
