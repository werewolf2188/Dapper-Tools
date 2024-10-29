using System.Collections.Generic;
using UnityEngine;

namespace DapperDino.DapperTools.StateMachines
{
    public class State : MonoBehaviour, IState
    {
        [SerializeField] private List<StateTransition> transitions = new List<StateTransition>();
        [SerializeField] [HideInInspector] float x;
        [SerializeField] [HideInInspector] float y;
    
        public float XCoordinate {
            get { return x; }
            set { x = newValue; }
        }
    
        public float YCoordinate {
            get { return y; }
            set { y = newValue; }
        }
    
        public List<StateTransition> Transitions {
            get {
                return transitions;
            }
        }

        public IState ProcessTransitions()
        {
            // Loop over all of the possible transitions from this state
            foreach (var transition in transitions)
            {
                // Check to see if the particular transition conditions are met
                if (transition.ShouldTransition())
                {
                    // Let the caller know which state we should transition to
                    return transition.NextState;
                }
            }

            // No transitions have all of their conditions met
            return null;
        }

        public void Enter() => gameObject.SetActive(true);

        public void Exit() => gameObject.SetActive(false);
    }
}
