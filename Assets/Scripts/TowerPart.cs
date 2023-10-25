using UnityEngine;
public class TowerPart : MonoBehaviour
{
    protected Animator _animator;
    protected BoxCollider _collider;
    private void Start()
    {
        _collider = GetComponent<BoxCollider>();
        _animator = GetComponent<Animator>();
    }
    protected virtual void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.TryGetComponent(out PlayerBullet playerBullet))
        {
            GlobalData.Score.UpdateScore();
            _collider.enabled = false;
            _animator.SetTrigger("Death");
            Destroy(gameObject, 0.16f);
        }
    }
}
