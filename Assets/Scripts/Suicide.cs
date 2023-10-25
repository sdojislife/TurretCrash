using UnityEngine;

public class Suicide : MonoBehaviour
{
    [SerializeField] private float _delay;
    private void Start()
    {
        Destroy(gameObject, _delay);
    }
}
