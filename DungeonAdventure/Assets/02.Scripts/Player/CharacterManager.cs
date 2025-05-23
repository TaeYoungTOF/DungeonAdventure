using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    #region Singletone
    private static CharacterManager _instance;
    public static CharacterManager Instance
    {
        get {
            if (_instance == null)
            {
                _instance = new GameObject("CharacterManager").AddComponent<CharacterManager>();
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

    // Player 객체 생성
    private Player _player;
    public Player Player
    {
        get { return _player; }
        set { _player = value; }
    }
}