using UnityEngine;

public class PenguinSound : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SoundManager.Instance.PlayPenguinSound();
        }
    }
}
