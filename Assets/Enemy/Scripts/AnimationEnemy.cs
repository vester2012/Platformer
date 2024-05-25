using UnityEngine;

namespace EnemySpace
{
    public class AnimationEnemy : MonoBehaviour
    {
        private Animator _animator;
        private Enemy _enemy;
        
        void Start()
        {
            _enemy = GetComponent<EnemySpace.Enemy>();
            _animator = GetComponent<Animator>();
        }

        // Update is called once per frame
        void Update() 
        {
            _animator.SetBool("isMove", _enemy.IsMoving);
        }
    }
}