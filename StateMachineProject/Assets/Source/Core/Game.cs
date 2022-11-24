using Source.InputSystem;
using Source.States;

namespace Source.Core
{
    public class Game
    {
        private PlayerInput _input;
        private InputHandler _inputHandler;
        private StateMachine _stateMachine;

        public Game(PlayerInput input, InputHandler inputHandler)
        {
            _input = input;
            _inputHandler = inputHandler;
        }

        private void Bind()
        {
            _input.Player.Forward.performed += _inputHandler.MoveForward;
            _input.Player.Back.performed += _inputHandler.MoveBack;
            _input.Player.Left.performed += _inputHandler.MoveLeft;
            _input.Player.Right.performed += _inputHandler.MoveRight;

            _input.StateMachine.InvokeState.performed += _inputHandler.InvokeState;
            _input.StateMachine.NextState.performed += _inputHandler.ChangeState;
        }

        private void UnBind()
        {
            _input.Player.Forward.performed -= _inputHandler.MoveForward;
            _input.Player.Back.performed -= _inputHandler.MoveBack;
            _input.Player.Left.performed -= _inputHandler.MoveLeft;
            _input.Player.Right.performed -= _inputHandler.MoveRight;
            
            _input.StateMachine.InvokeState.performed -= _inputHandler.InvokeState;
            _input.StateMachine.NextState.performed -= _inputHandler.ChangeState;
        }
        public void StartGame()
        {
            _input.Player.Enable();
            _input.StateMachine.Enable();
            Bind();
        }
    }
}
