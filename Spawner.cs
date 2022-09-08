using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
    [SerializeField] private Enemy _enemyPrefab;
   
    public void CreateEnemy() {
        Enemy newEnemy = Instantiate(_enemyPrefab, transform.position, Quaternion.identity, transform);
    }
}
