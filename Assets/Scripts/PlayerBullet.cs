using UnityEngine;
public class PlayerBullet : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    private SphereCollider _collider;
    private void Start()
    {
        _collider = GetComponent<SphereCollider>();
    }
    private void Update()
    {
        transform.Translate(Vector3.forward * _moveSpeed * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.TryGetComponent(out TowerPart towerPart))
        {
            _collider.enabled = false;
        }
        if (collision.gameObject.TryGetComponent(out Enemy enemy))
        {
            GlobalData.GameOver.enabled = true;
            GlobalData.GameOver.ShowUI();
        }
    }
}
