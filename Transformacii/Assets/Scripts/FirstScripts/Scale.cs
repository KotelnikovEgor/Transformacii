using UnityEngine;

public class Scale : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Vector3 _max;

    private Vector3 _min;
    private int _sign = 1;

    private void Start()
    {
        _min = transform.localScale;
    }

    private void Update()
    {
        transform.localScale += _speed * _sign * Time.deltaTime * Vector3.one;

        if (transform.localScale.x > _max.x)
            _sign = -1;
        else if (transform.localScale.x < _min.x)
            _sign = 1;
    }
}
