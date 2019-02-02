using UnityEngine;
using System.Collections;

namespace SA
{
	public class PlayerStatesManager : StateManager
	{
		public float horizontal;
		public float vertical;

		protected override void Init()
		{
			State locomotion = new State(
				//Fixed Update Actions
				new StateAction[] {

				}
				,// Update Actions
				new StateAction[] {
					new InputManager(this,"testAction"),
					new SecondAction()
				}
			);

			State testState = new State (
				null
				,
				new StateAction[] {
					new TestAction(this, "locomotion"),
				}
			);

			allStates.Add("locomotion", locomotion);
			allStates.Add("testAction", testState);

			SetState("locomotion");
		}

		private void FixedUpdate()
		{
			FixedTick();
		}

		private void Update()
		{
			Tick();
		}
	}
}
