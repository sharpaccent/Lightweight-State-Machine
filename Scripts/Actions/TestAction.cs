using UnityEngine;
using System.Collections;

namespace SA
{
	public class TestAction : StateAction
	{
		PlayerStatesManager states;
		string locomotionState;

		public TestAction(PlayerStatesManager playerStatesManager, string locomotionState)
		{
			states = playerStatesManager;
			this.locomotionState = locomotionState;
		}

		public override bool Execute()
		{
			Debug.Log("this is the test state");

			if (Input.GetKeyDown(KeyCode.Space))
			{
				states.SetState(locomotionState);
			}

			return false;
		}
	}
}
