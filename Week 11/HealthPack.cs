using UnityEngine;

public class HealthPack : MonoBehaviour
{
    public PlayerHealth playerHealth;
   
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (playerHealth.health < 100)
            {
                playerHealth.health = Mathf.Min(playerHealth.health + 10, 100);
            }

            Destroy(gameObject);

        }
    }
}