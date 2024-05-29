using UnityEngine;

namespace EnemySpace
{
    public class Enemy : MonoBehaviour
    {
        [Header("Movement")]
        [SerializeField] private float _speed = 1;
    
        [Header("CollisionInfo")]
        [SerializeField] private Transform _checkTransform;
    
        private bool _isMoving;
        public bool IsMoving => _isMoving;
    
        internal Rigidbody2D  _rb;
    
        void Start()
        {
            _rb = GetComponent<Rigidbody2D>();
        }
    
        void Update()
        {
            _isMoving = _rb.velocity.x != 0;
        }
    
        private void FixedUpdate()
        {
            _rb.velocity = new Vector2(-13 * _speed, _rb.velocity.y);
        }
    
        private void OnCollisionEnter2D(Collision2D other)
        {
            
        }
    }
}

