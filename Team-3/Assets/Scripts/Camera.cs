using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] Vector3 offset;

    private void Update()
    {
        transform.position = player.position - offset;
    }
}
