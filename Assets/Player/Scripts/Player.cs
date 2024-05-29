using UnityEngine;

namespace PlayerSpace {
    public class Player : MonoBehaviour
    {
        [Header("Movement")]
        [SerializeField] private float _speed = 1;
        [SerializeField] private float _jumpForce = 2;

        [Header("CollisionInfo")]
        [SerializeField] private Transform _checkTransform;
        [SerializeField] private float _groundCheckRadius;
        [SerializeField] private LayerMask _groundLayerMask;
        internal bool _isGrounded;
        internal bool _isDoubleGrounded;
        
        private bool _isMoving;
        public bool IsMoving => _isMoving;
        
        private bool _isFlip = true;
        
        internal Rigidbody2D  _rb;

        private MovementController _movementController;
    
        void Start()
        {
            _movementController = GetComponent<MovementController>();
            _rb = GetComponent<Rigidbody2D>();
        }
    
        void Update()
        {
            _isMoving = _rb.velocity.x != 0;
            
            Flip();
            CollisionCheck();
        }
        
        private void CollisionCheck()
        {
            _isGrounded = Physics2D.OverlapCircle(_checkTransform.position, _groundCheckRadius, _groundLayerMask);
        }
        
        internal void Jump()
        {
            if (_isGrounded)
            {
                _rb.velocity = new Vector2(_rb.velocity.x, _jumpForce);
            } 
            else if (_isDoubleGrounded)
            {
                _isDoubleGrounded = false;
                _rb.velocity = new Vector2(_rb.velocity.x, _jumpForce);
            }
        }
 
        private void FixedUpdate()
        {
            _rb.velocity = new Vector2(_movementController._moveInput * _speed, _rb.velocity.y);
        }

        private void Flip()
        {
            if ((_rb.velocity.x > 0 && !_isFlip) || (_rb.velocity.x < 0 && _isFlip))
            {
                _isFlip = !_isFlip;
                transform.Rotate(0, 180, 0);
            }
        }

        private void OnCollisionEnter2D(Collision2D other)
        {
            if (other.gameObject.name == "Enemy" && other.collider.name == "Collider2")
            {
                Destroy(this.gameObject);
            }
            else if (other.gameObject.name == "Enemy" && other.collider.name == "Collider1")
            {
                Destroy(other.gameObject);
            }
        }
    }
}