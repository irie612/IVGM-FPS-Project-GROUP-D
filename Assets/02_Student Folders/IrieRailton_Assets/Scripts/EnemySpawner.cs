using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [Header("Parameters")] 
    [Tooltip("Number of Waves of Enemies to Spawn")] public int numberOfWaves;

    [Tooltip("Number of Enemies per Wave")] public int enemiesPerWave;

    [Tooltip("EnemyPrefab")] public GameObject enemy;

    private bool _spawning;
    private int _waveCounter;

    private GameObject _monumentReference;
    
    private List<GameObject> _enemies;
    
    // Start is called before the first frame update
    void Start()
    {
        _enemies = new List<GameObject>();
        _spawning = false;
        _waveCounter = 0;
        _monumentReference = GameObject.Find("Monument Pivot");

    }

    // Update is called once per frame
    void Update()
    {
        if(_spawning && _waveCounter < numberOfWaves)
        {
            SpawnWave();
        }

        
        
        UpdateEnemies();
        if (_waveCounter > 0 && _enemies.Count == 0)
        {
            if (_waveCounter == numberOfWaves)
            {
                if (_monumentReference.transform.rotation.eulerAngles.z < 90f)
                {
                    print(_monumentReference.transform.rotation.eulerAngles.y);
                    _monumentReference.transform.Rotate(0f, 0f, 1f, Space.World);
                }
            }
            else
            {
                SetSpawning();
            }
        }
    }

    public void SetSpawning()
    {
        _spawning = true;
    }

    void SpawnWave()
    {
        _spawning = false;
        _waveCounter++;
        
        Vector3 spawnPos;
        spawnPos.y = -48;
        
        for (int i = 0; i < enemiesPerWave; i++)
        {
            spawnPos.x = Random.Range(64f, 80f);
            spawnPos.z = Random.Range(41f, 60f); 
            _enemies.Add(Instantiate(enemy, spawnPos, Quaternion.identity));
        }

    }

    void UpdateEnemies()
    {
        _enemies = _enemies.Where(e => e != null).ToList();
    }
}