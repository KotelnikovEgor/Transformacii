using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        transform.Rotate(_speed * Time.deltaTime * Vector3.up);
    }
}
