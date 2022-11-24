using System;
using DG.Tweening;
using UnityEngine;

namespace Source.States
{
    [Serializable]
    public class ShieldState : AState
    {
        private bool _isActive;
        private SpriteRenderer _shieldBody;
        
        public ShieldState(SpriteRenderer body)
        {
            _shieldBody = body;
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
                _shieldBody.DOFade(1, 1);
                _isActive = false;
            }
            else
            {
                _shieldBody.DOFade(0, 1);
                _isActive = true;
            }
        }
    }
}