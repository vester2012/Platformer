using PlayerSpace;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trap : MonoBehaviour
{
    protected virtual void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Player>() != null)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            Destroy(collision.gameObject);
        }
    }
}
