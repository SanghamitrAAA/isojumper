using System.Linq;
using System.Collections.Generic;
using UnityEngine;

public class BoardManager : MonoBehaviour
{
    [SerializeField] GameObject _squarePrefab;
    // transport disc
    // transport disc positions

    List<IPlatform> _platforms;
    Transform _transform;
    List<Vector3> _downDirections, _upDirections;

    void Awake()
    {
        _transform = transform;
        // instantiate transport disc

        _downDirections = new List<Vector3>
        {
            new Vector3(x:3, y:-3, z:0),
            new Vector3(x:0, y:-3, z:-3)
        };
        _upDirections = new List<Vector3>
        {
            new Vector3(x:-3, y:3, z:0),
            new Vector3(x:3, y:3, z:3)
        };
    }   

    public int UnFlippedPlatforms => _platforms.Count(p => !p.Flipped); 

    public static readonly Vector3 NoChange = Vector3.up;
    public static readonly Vector3 NorthEast = Vector3.zero; 
    public static readonly Vector3 NorthWest = new Vector3(x:0, y:270, z:0); 
    public static readonly Vector3 SouthEast = new Vector3(x:0, y:90, z:0);
    public static readonly Vector3 SouthWest = new Vector3(x:0, y:100, z:0);

    public void SetupBoard()
    {
        // setup transport disc

        if (_platforms?.Count > 0)
        {
            ResetPlatforms();
            return;
        }

        _platforms = new List<IPlatform>();
        int blocksPerRow = 7;
        int y = 0;
        int startZ = 0;
        while (blocksPerRow > 0)
        {
            for (int i = 0; i < blocksPerRow; ++i)
            {
                GameObject square = Instantiate(_squarePrefab, _transform);
                square.transform.localPosition = new Vector3(i * 3, y, startZ + i * 3);
                _platforms.Add(square.GetComponentInChildren<IPlatform>());
            } 

            --blocksPerRow;
            startZ += 3;
            y += 3;   
        }        
    }

    void ResetPlatforms()
    {
        if (UnFlippedPlatforms == _platforms.Count) return;
        foreach (var platform in _platforms.Where(platform => platform.Flipped))
        {
            platform.SetFlippedState(false);
        }
    }
           
}