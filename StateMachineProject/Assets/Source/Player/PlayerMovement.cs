using System;
using UnityEngine;

namespace Source.Player
{
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] private float speedMove;

        private Rigidbody2D _rb;
        private bool _isForward;
        private bool _isBack;
        private bool _isRight;
        private bool _isLeft;

        private void Start()
        {
            _rb = GetComponent<Rigidbody2D>();
        }

        public void MoveForward(float value)
        {
            _isForward = value != 0f;
        }
        public void MoveBack(float value)
        {
            _isBack = value != 0f;
        }
        public void MoveLeft(float value)
        {
            _isLeft = value != 0f;
        }
        public void MoveRight(float value)
        {
            _isRight = value != 0f;
        }

        private void FixedUpdate()
        {
            if (_rb.velocity.x > speedMove)
            {
                _rb.velocity = new Vector2(speedMove, _rb.velocity.y);
            }
            if (_rb.velocity.x < -speedMove)
            {
                _rb.velocity = new Vector2(-speedMove, _rb.velocity.y);
            }
            if (_rb.velocity.y > speedMove)
            {
                _rb.velocity = new Vector2(_rb.velocity.x,speedMove);
            }
            if (_rb.velocity.y < -speedMove)
            {
                _rb.velocity = new Vector2(_rb.velocity.x,-speedMove);
            }
            
            if (_isForward)
            {
                _rb.AddForce(Vector2.up * speedMove, ForceMode2D.Impulse);
            }

            if (_isBack)
            {
                _rb.AddForce(Vector2.down * speedMove, ForceMode2D.Impulse);
            }
            if (_isLeft)
            {
                _rb.AddForce(Vector2.left * speedMove, ForceMode2D.Impulse);
            }
            if (_isRight)
            {
                _rb.AddForce(Vector2.right * speedMove, ForceMode2D.Impulse);
            }
        }
    }
}
