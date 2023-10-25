using UnityEngine;

public class OutofBoundsDeath : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.TryGetComponent(out Boundary boundary))
        {
            Destroy(gameObject);
        }
    }
}
