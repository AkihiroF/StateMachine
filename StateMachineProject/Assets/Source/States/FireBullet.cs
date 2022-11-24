using System;
using DG.Tweening;
using UnityEngine;

namespace Source.States
{
    [Serializable]
    public class FireBullet : AState
    {
        private GameObject _bulletBody;
        private Transform _startPoint;
        public override void Enter()
        {
            _bulletBody.SetActive(true);
            _bulletBody.transform.position = new Vector3(122, 222);
        }

        public override void Exit()
        {
            _bulletBody.SetActive(false);
        }

        public override void Update()
        {
            _bulletBody.transform.DOComplete();
            _bulletBody.transform.position = _startPoint.position;
            var finish = _startPoint.up * 100;
            _bulletBody.transform.DOMove(finish, 10);
        }

        public FireBullet(GameObject bullet, Transform startPoint)
        {
            _bulletBody = bullet;
            _startPoint = startPoint;
            bullet.SetActive(false);
        }
    }
}