using UnityEngine;

public class Camara : MonoBehaviour
{
    private Transform _player;
    public Vector3 offset;

    private void Update()
    {
        if (_player != null)
        {
            transform.position = _player.position + offset;
            transform.LookAt(_player);

            Vector3 rotation = transform.eulerAngles;
            rotation.y = _player.eulerAngles.y;
            transform.eulerAngles = rotation;
        }


    }
}
