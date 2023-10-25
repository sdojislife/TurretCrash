using UnityEngine;

public class PlayerCannon : MonoBehaviour
{
    [SerializeField] private PlayerBullet _bullet;
    [SerializeField] private Animator _animator;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(_bullet, transform.position, Quaternion.identity);
            _animator.SetTrigger("Shoot");
        }
    }
}
