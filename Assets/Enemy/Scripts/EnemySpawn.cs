using UnityEngine;

namespace EnemySpace
{
    public class EnemySpawn : MonoBehaviour
    {
        // Ссылка на префаб, который мы будем создавать
        [SerializeField] private GameObject _enemy;
        [SerializeField] private float spawnInterval = 2f;
        private float _timer;
        
        void Start()
        {
            _timer = spawnInterval;
        }

        private void Update()
        {
            _timer -= Time.deltaTime;
            
            if (_timer <= 0f)
            {
                Instantiate(_enemy, transform.position, transform.rotation);
                
                _timer = spawnInterval;
            }
        }
    }
}