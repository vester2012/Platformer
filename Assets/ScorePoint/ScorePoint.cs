using PlayerSpace;
using UnityEngine;

public class ScorePoint : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Player>() != null)
        {
            Debug.Log("update score");
            Destroy(this.gameObject);
        }
    }
}