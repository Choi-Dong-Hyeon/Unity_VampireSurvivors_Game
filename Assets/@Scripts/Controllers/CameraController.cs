using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject _player;


    
    void LateUpdate()
    {
        transform.position = new Vector3(_player.transform.position.x, _player.transform.position.y, -10f);
    }
}
