using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SA
{
	public class State
	{
		StateAction[] updateActions;
		StateAction[] fixedActions;

		bool forceSkip;

		public State(StateAction[] fixedUpdateActions,StateAction[] updateActions)
		{
			this.updateActions = updateActions;
			fixedActions = fixedUpdateActions;
		}

		public void FixedTick()
		{
			ExecuteActionsArray(fixedActions);
		}

		public void Tick()
		{
			ExecuteActionsArray(updateActions);
			forceSkip = false;
		}

		void ExecuteActionsArray(StateAction[] list)
		{
			if (list == null)
				return;

			for (int i = 0; i < list.Length; i++)
			{
				if (forceSkip)
					break;

				forceSkip = list[i].Execute();
			}
		}
	}
}
