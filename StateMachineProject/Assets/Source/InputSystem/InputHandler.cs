using Source.Player;
using Source.States;
using UnityEngine.InputSystem;

namespace Source.InputSystem
{
    public class InputHandler
    {
        private PlayerMovement _playerMovement;
        private StateMachine _stateMachine;

        public InputHandler(PlayerMovement movement, StateMachine stateMachine)
        {
            _playerMovement = movement;
            _stateMachine = stateMachine;
        }

        public void MoveForward(InputAction.CallbackContext button)
        {
            _playerMovement.MoveForward(button.ReadValue<float>());
        }

        public void MoveBack(InputAction.CallbackContext button)
        {
            _playerMovement.MoveBack(button.ReadValue<float>());
        }

        public void MoveLeft(InputAction.CallbackContext button)
        {
            _playerMovement.MoveLeft(button.ReadValue<float>());
        }

        public void MoveRight(InputAction.CallbackContext button)
        {
            _playerMovement.MoveRight(button.ReadValue<float>());
        }

        public void InvokeState(InputAction.CallbackContext button)
        {
            _stateMachine.InvokeState();
        }

        public void ChangeState(InputAction.CallbackContext button)
        {
            _stateMachine.NextState();
        }
    }
}
