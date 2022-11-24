using Source.InputSystem;
using Source.Player;
using Source.States;
using TMPro;
using UnityEngine;

namespace Source.Core
{
    public class Bootstrapper : MonoBehaviour
    {
        [SerializeField] private PlayerMovement playerMovement;
        [SerializeField] private InitializerState initializerState;
        [SerializeField] private TextMeshProUGUI outputText;
        private Game _game;
        private PlayerInput _input;
        private InputHandler _inputHandler;
        private StateMachine _stateMachine;
        
        private void Awake()
        {
            _stateMachine = new StateMachine(initializerState.Initialize(), outputText);
            _inputHandler = new InputHandler(playerMovement, _stateMachine);
            _input = new PlayerInput();
            
            _game = new Game(_input, _inputHandler);
            _game.StartGame();
        }
    }
}
