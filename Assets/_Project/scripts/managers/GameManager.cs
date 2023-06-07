using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance; 
    [SerializeField] GameObject _geckoPrefab;
    [SerializeField] Vector3 _geckoStartPosition, _geckoStartRotation;

    public enum GameStates
    {
        Ready,
        GameStarted,
        RoundStarted,
        PlayerDied,
        LevelComplete,
        Gameover,
    }

    GameStates _gameState;
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
    
    public UnityEvent GameStateChanged = new UnityEvent();
    public UnityEvent LivesChanged = new UnityEvent();
    public Transform gecko => _gecko.transform;
    public BoardManager BoardManager => _boardManager;

    Transform _transform;
    BoardManager _boardManager;
    Vector3 _geckoSpawnPosition, _geckoSpawnRotation;

    //instantiate Prefab:
    //GameObject _gecko;
    Gecko_Script _gecko;

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

    void Update()
    {
        if (GameState != GameStates.Ready) return;
        if (Input.anyKeyDown)
        {
            StartGame();
        }
    }

    void StartGame()
    {
        GameState = GameStates.GameStarted;
        Lives = 3;
        // set next extra life
        StartRound();
    }

    void StartRound()
    {
        SpawnGecko();
        GameState = GameStates.RoundStarted;
        // start game music
    }

    void SpawnGecko()
    {
        if (!_gecko)
        {
            _gecko = Instantiate(_geckoPrefab, _transform).GetComponent<Gecko_Script>();
            //_gecko = Instantiate(_geckoPrefab, _transform);
        }
        // method on Gecko to reset all its settings
        _gecko.ResetGecko(_geckoSpawnPosition, _geckoSpawnRotation);
    }

    void ReadyToPlay()
    {
        // star music
        Lives = 3;
        // set next extra life interval
        // reset score
        // reset Geckos position
        ResetGeckoSpawnPosition();
        GameState = GameStates.Ready;
    }

    void ResetGeckoSpawnPosition(bool useLastPosition = false)
    {
        if (useLastPosition)
        {
            _geckoSpawnPosition = _gecko.transform.position;
            _geckoSpawnRotation = _gecko.Body.eulerAngles;
            return;
        }

        _geckoSpawnPosition = _geckoStartPosition;
        _geckoSpawnRotation = _geckoStartRotation;
    }

    public void PlayerDied()
    {
        // todo
        GameState = GameStates.PlayerDied;
        // Change Background Color when dead
        //cam.backgroundColor = Color.Lerp(color1, color2, color3, _rotationTimer);
    }
}

