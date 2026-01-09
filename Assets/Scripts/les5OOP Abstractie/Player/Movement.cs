using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;
    private float _inputHorizontal;
    private float _inputVertical;

    private void Update()
    {
        _inputHorizontal = Input.GetAxisRaw("Horizontal");
        _inputVertical = Input.GetAxisRaw("Vertical");

        Vector3 movement = new Vector3 (_inputHorizontal, 0, _inputVertical) * _speed *Time.deltaTime;
        transform.position += movement;
    }
}
