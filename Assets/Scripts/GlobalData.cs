using UnityEngine;

public class GlobalData : MonoBehaviour
{
    public static Score Score;
    public static GameOver GameOver;
    public static TowerSpawner TowerSpawner;
    private void Start()
    {
        GameOver = FindObjectOfType<GameOver>();
        TowerSpawner = FindObjectOfType<TowerSpawner>();
        Score = FindObjectOfType<Score>();
    }
}
