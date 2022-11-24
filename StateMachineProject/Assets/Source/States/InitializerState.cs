using System.Collections.Generic;
using UnityEngine;

namespace Source.States
{
    public class InitializerState : MonoBehaviour
    {
        [SerializeField] private GameObject bullet;
        [SerializeField] private GameObject bodyPlayer;
        [SerializeField] private SpriteRenderer shieldBody;

        public List<AState> Initialize()
        {
            var states = new List<AState>();
            states.Add(new FireBullet(Instantiate(this.bullet), bodyPlayer.transform));
            states.Add(new ShieldState(shieldBody));
            states.Add(new UnVisibleState(bodyPlayer.GetComponent<SpriteRenderer>()));
            return states;
        }

    }
}