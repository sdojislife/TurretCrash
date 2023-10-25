using UnityEngine;
using UnityEngine.Events;
public class TopTowerPart : TowerPart
{
    [SerializeField] private UnityEvent _onDestroyedEvent;
    protected override void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.TryGetComponent(out PlayerBullet playerBullet))
        {
            _collider.enabled = false;
            _animator.SetTrigger("Death");
            GlobalData.TowerSpawner.Spawn();
            transform.parent.parent.DetachChildren();
            _onDestroyedEvent.Invoke();
        }
    }
}
