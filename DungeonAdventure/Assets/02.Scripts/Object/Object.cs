using UnityEngine;

public interface IObject
{
    public string GetInteractPrompt();
}

public class Object : MonoBehaviour, IObject
{
    public ItemData data;
    [SerializeField] private ObjectType type;

    [Header("Jump")]
    [SerializeField] private float jumpPower;

    public string GetInteractPrompt()
    {
        string str = $"{data.displayName}\n{data.description}";

        return str;
    }

    private void OnCollisionEnter(Collision collision)
    {
        switch (type)
        {
            case ObjectType.Jump:
                if (collision.gameObject.CompareTag("Player") && collision.transform.position.y > gameObject.transform.position.y + 0.1)
                {
                    collision.rigidbody.AddForce(Vector2.up * jumpPower, ForceMode.Impulse);
                }
                break;
            case ObjectType.Replace:
                if (collision.gameObject.CompareTag("Player"))
                {
                    GameManager.Instance.ReplacePlayer();
                }
                break;
        }
    }
}
