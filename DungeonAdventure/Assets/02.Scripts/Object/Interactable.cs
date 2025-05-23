using UnityEngine;

public interface IInteractable
{
    public string GetInteractPrompt();
}

public class Interactable : MonoBehaviour, IInteractable
{
    public ItemData data;
    [SerializeField] private InteractableType type;

    [Header("Spawnjump")]
    [SerializeField] private GameObject[] jumps;

    private Coroutine coroutine;

    void Start()
    {
        if (coroutine != null) return;
    }

    public string GetInteractPrompt()
    {
        string str = $"{data.displayName}\n{data.description}";

        return str;
    }

    public void OnInteract()
    {

    }
}
