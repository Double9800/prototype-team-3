using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    [SerializeField] GameObject canna;
    [SerializeField] GameObject projectiles;


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(bullet, canna.transform.position, canna.transform.rotation, projectiles.transform);
        }
    }
}
