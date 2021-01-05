using UnityEngine;

public class ShootEnemy : MonoBehaviour
{
    [SerializeField]
    private GameObject enemyBullet;
    [SerializeField]
    private Transform canna;
    [SerializeField]
    private float maxTimer;
    [SerializeField]
    private float Timer;
    [SerializeField] GameObject projectiles;






    void Start()
    {
        Timer = maxTimer;
    }


    void Update()
    {
        Shoot();
    }

    private void Shoot()
    {
        Timer -= Time.deltaTime;
        if (Timer <= 0)
        {
            Instantiate(enemyBullet, canna.transform.position, canna.transform.rotation, projectiles.transform);
            Timer = maxTimer;
        }
    }
}
