using System.Collections;
using UnityEngine;
using UnityEngine.Events;
//using UnityEngine;SceneManagment;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance; 
    //[SerializeField] GameObject _geckoPrefab;
    //[SerializeField] Vector3 _geckoStartPosition, _geckoStartRotation;

    //for Level 2
    public static int remainingTiles = 45;

    //Transform _transform;
    //Vector3 _geckoSpawnPosition, _geckoSpawnRotation;

    public enum GameStates
    {
        Ready,
        GameStarted,
        RoundStarted,
        PlayerDied,
        LevelComplete,
        Gameover,
    }
    //TestMovement _gecko;
    GameStates _gameState;
    Timer _timer;
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
    //public Transform gecko => _gecko.transform;

    void Awake()
    {
        if (Instance != null && this != Instance)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        //_transform = transform;
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
        if (remainingTiles == 0)
        {
            Debug.Log("You win");
            // play level clear video

            //MOVE TO NEXT LEVEL
            //StartCoroutine(loadNextLevel());
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
        // play "3,2,1 go!" video
        GameState = GameStates.RoundStarted;
        // start game music
    }

    void ReadyToPlay()
    {
        // start music
        Lives = 3;
        // set next extra life interval
        // reset score
        // reset Geckos position
        //ResetGeckoSpawnPosition();
        GameState = GameStates.Ready;
    }

    public void PlayerDied()
    {
        // todo
        GameState = GameStates.PlayerDied;
        // Change Background Color when dead
        // play gameover video
    }

    //INSTANCIATE BUFFER TO LOAD NEXT LEVEL
    //IEnumerator loadNextLevel()
    //{
    //    yield return new WaitForSeconds(5);
    //    remainingTiles = 45; //(add more for every level)
    //    SceneManager.LoadScene("level1");
    //}
}

