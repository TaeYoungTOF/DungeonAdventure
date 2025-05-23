using UnityEngine;

enum ObjectType
{
    Jump,
    Replace
}

enum InteractableType
{
    SpawnJump
}

[CreateAssetMenu(fileName = "ItemData", menuName = "New Item", order = 1)]
public class ItemData : ScriptableObject
{
    [Header("Info")]
    public string displayName;
    public string description;
}
