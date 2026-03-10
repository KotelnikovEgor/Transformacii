using UnityEngine;

public class TargetMovement : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Transform[] _targets;

    private int _currentTarget = 0;

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _targets[_currentTarget].position, _speed * Time.deltaTime);

        if(transform.position == _targets[_currentTarget].position)
            _currentTarget = (_currentTarget + 1) % _targets.Length;
    }
}
