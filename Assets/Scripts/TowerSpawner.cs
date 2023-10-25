using UnityEngine;

public class TowerSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] _towers;
    public void Spawn() => Instantiate(_towers[Random.Range(0,_towers.Length)], new Vector3(4, 0, -3), Quaternion.identity);
}
