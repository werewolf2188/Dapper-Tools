using UnityEngine;

namespace DapperDino.DapperTools.StateMachines
{
    public abstract class StateTransitionCondition : MonoBehaviour
    {
        public State NextState { get; set; }
        public abstract bool IsMet();
    }
}
