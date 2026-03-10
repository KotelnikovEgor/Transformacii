using UnityEngine;

public class LocalMovement : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        transform.Translate(_speed * Time.deltaTime * Vector3.forward);
    }
}
