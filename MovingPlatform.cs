using System.Collections;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    [SerializeField] private float moveSpeed;

    [SerializeField] private Vector3[] moveSteps = new[]
    {
    Vector3.up * 500,
    Vector3.left * 500,
    Vector3.down * 500,
    Vector3.right * 500
};

    private IEnumerator Start()
    {
        while (true)
        {
            foreach (var step in moveSteps)
            {
                var currentTargetPosition = transform.position + step;
                
                while (!Mathf.Approximately(Vector3.Distance(transform.position, currentTargetPosition), 0f))
                {
                    transform.position = Vector3.MoveTowards(transform.position, currentTargetPosition, moveSpeed * Time.deltaTime);

                    yield return null;
                }

                transform.position = currentTargetPosition;
            }
        }
    }
}
