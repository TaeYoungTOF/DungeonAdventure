using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    #region Singletone
    private static GameManager _instance;
    public static GameManager Instance
    {
        get {
            if (_instance == null)
            {
                _instance = new GameObject("GameManager").AddComponent<GameManager>();
            }
            return _instance;
        }
    }

    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            if (_instance = this)
            {
                Destroy(gameObject);
            }
        }
    }
    #endregion

    [Header("Health")]
    [SerializeField] private float curHealth;
    [SerializeField] private float maxHealth;
    [SerializeField] private float passiveValue;
    [SerializeField] private Image healthbar;

    [Header("Score")]
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private int score;

    private void Start()
    {
        curHealth = maxHealth;
    }

    private void Update()
    {
        healthbar.fillAmount = curHealth / maxHealth;
        scoreText.text = score.ToString();
    }

    public float ChangeHealth (float value)
    {
        curHealth = Mathf.Clamp(curHealth + value, 0, maxHealth);

        return curHealth;
    }

    public void AddScore(int value)
    {
        score += value;
    }

    public void ReplacePlayer()
    {
        Vector3 startingPoint = new Vector3 (10, 0, 0);

        CharacterManager.Instance.Player.transform.position = startingPoint;
    }
}