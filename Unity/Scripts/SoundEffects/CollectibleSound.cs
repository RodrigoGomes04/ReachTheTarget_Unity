using UnityEngine;

public class CollectibleSound : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SoundManager.Instance.PlayCollectibleSound();
        }
    }
}
