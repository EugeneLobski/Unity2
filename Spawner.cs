using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
    [SerializeField] private GameObject _enemyPrefab;
   
    public void CreateEnemy() {
        Instantiate(_enemyPrefab, transform.position, Quaternion.identity, transform);
    }
}
