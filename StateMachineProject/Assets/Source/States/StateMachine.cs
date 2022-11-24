using System.Collections.Generic;
using TMPro;

namespace Source.States
{
    public class StateMachine
    {
        private Dictionary<int, AState> _states;
        private TextMeshProUGUI _outputState;
        private int _currentState = 0;
        
        
        public StateMachine(List<AState> states, TextMeshProUGUI output)
        {
            _outputState = output;
            ApplyStates(states);
            _states[_currentState].Enter();
            _outputState.text = _states[_currentState].ToString();
        }

        private void  ApplyStates(List<AState> states)
        {
            _states = new Dictionary<int, AState>();
            for (int i = 0; i < states.Count; i++)
            {
                _states.Add(i, states[i]);
            }
        }

        public void NextState()
        {
            _states[_currentState].Exit();
            if (_currentState < _states.Count-1)
            {
                _currentState++;
            }
            else
            {
                _currentState = 0;
            }
            _states[_currentState].Enter();
            _outputState.text = _states[_currentState].ToString();
        }

        public void InvokeState()
        {
            _states[_currentState].Update();
        }
    }
}