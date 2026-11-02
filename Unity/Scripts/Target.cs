using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
public class Target : MonoBehaviour
{
    [SerializeField] private int targetsToAdd;
    [SerializeField] private int pointsToAdd;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            ScoreManager.Instance.IncreaseScore(pointsToAdd);
            TargetManager.Instance.IncreaseTargets(targetsToAdd);
            Destroy(gameObject);
        }
    }
}
