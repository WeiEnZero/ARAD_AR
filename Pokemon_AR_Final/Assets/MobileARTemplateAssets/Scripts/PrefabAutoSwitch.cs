using UnityEngine;
using UnityEngine.UI;

public class PrefabAutoSwitch : MonoBehaviour
{
    [Header("UI")]
    [SerializeField] private Button switchButton;

    [Header("Prefabs (Root Objects)")]
    [SerializeField] private GameObject prefabA;
    [SerializeField] private GameObject prefabB;

    private bool isAOn = true;

    private void Awake()
    {
        // Safety checks
        if (switchButton == null || prefabA == null || prefabB == null)
        {
            Debug.LogWarning("[PrefabAutoSwitch] Missing required references.");
            return;
        }

        // Initial state: Show A, Hide B
        prefabA.SetActive(true);
        prefabB.SetActive(false);

        // Button click listener
        switchButton.onClick.AddListener(OnButtonClicked);
    }

    private void OnDestroy()
    {
        // Clean up listener
        if (switchButton != null)
        {
            switchButton.onClick.RemoveListener(OnButtonClicked);
        }
    }

    private void OnButtonClicked()
    {
        if (isAOn)
        {
            prefabA.SetActive(false);
            prefabB.SetActive(true);
        }
        else
        {
            prefabB.SetActive(false);
            prefabA.SetActive(true);
        }

        isAOn = !isAOn;
    }
}
