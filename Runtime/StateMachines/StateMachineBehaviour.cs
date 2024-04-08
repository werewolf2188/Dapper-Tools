using UnityEngine;

namespace DapperDino.DapperTools.StateMachines
{
    public class StateMachineBehaviour : MonoBehaviour
    {
        [SerializeField] private State startingState = null;
        public State StartingState {
            get {
                return startingState;
            }
        }

        private StateMachine stateMachine;
        public StateMachine StateMachine
        {
            get
            {
                if (stateMachine != null) { return stateMachine; }
                stateMachine = new StateMachine(startingState);
                return stateMachine;
            }
        }

        private void Update() => StateMachine.Tick();

        public void ChangeState(State state) => StateMachine.ChangeState(state);
    }
}
