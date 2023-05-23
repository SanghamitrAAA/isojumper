using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance; 

    public enum GameStates
    {
        Ready,
        GameStarted,
        RoundStarted,
        QBertDied,
        LevelComplete,
        Gameover,
    }

    private GameStates _gameState;
    public GameStates GameState
    {
        get => _gameState;
        set
        {
            _gameState = value;
            // fire GameStateChanged event
            GameStateChanged.Invoke();
        }
    }

    public bool IsPlaying => GameState == GameStates.RoundStarted;
    int _lives;

    public int Lives
    {
        get => _lives;
        private set
        {
            _lives = value;

            // fire Lives Changed event
            LivesChanged.Invoke();
        }
    }
    
    public UnityEvent LivesChanged = new UnityEvent();
    public UnityEvent GameStateChanged = new UnityEvent();

    Transform _transform;
    BoardManager _boardManager;

    void Awake()
    {
        if (Instance != null && this != Instance)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        _transform = transform;
        _boardManager = GetComponent<BoardManager>();
    }    

    void Start()
    {
        ReadyToPlay();
    }

    void ReadyToPlay()
    {
        // star music
        Lives = 3;
        // set next extra life interval
        // reset score
        _boardManager.SetupBoard();
        // reset Berts position
         GameState = GameStates.Ready;
    }
}

