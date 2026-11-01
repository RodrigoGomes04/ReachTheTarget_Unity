using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class TargetManager : MonoBehaviour
{
    public int levelToChange;
    [SerializeField] private TMP_Text WinText;
    [SerializeField] private TMP_Text targetsText;
    [SerializeField] private int targets;
    [SerializeField] private int totalTargets;

    public static TargetManager Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }

        else
        {
            Destroy(gameObject);
        }

    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        WinText.text = "REACH THE TARGET!";
        targetsText.text = "TARGETS: " + targets + "/" + totalTargets;
    }

    public void IncreaseTargets(int amount)
    {
        targets += amount;
        targetsText.text = "TARGETS: " + targets + "/" + totalTargets;
        if (targets >= totalTargets)
        {
            WinText.text = "TARGET REACHED!";
            Debug.Log("TARGET REACHED!");
        }
    }

    void Update()
    {
        if (targets >= totalTargets)
        {
            SceneManager.LoadScene(levelToChange);
        }
    }
}
