using System;
using DG.Tweening;
using UnityEngine;

namespace Source.States
{
    public class UnVisibleState : AState
    {
        private SpriteRenderer _bodyPlayer;
        private bool _isActive;
        public UnVisibleState(SpriteRenderer body)
        {
            _bodyPlayer = body;
        }

        public override void Enter()
        {
            
        }

        public override void Exit()
        {
            
        }

        public override void Update()
        {
            if (_isActive)
            {
                _bodyPlayer.DOFade(1, 1);
                _isActive = false;
            }
            else
            {
                _bodyPlayer.DOFade(0.2f, 1);
                _isActive = true;
            }
        }
    }
}