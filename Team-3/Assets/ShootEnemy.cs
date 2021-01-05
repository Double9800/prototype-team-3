using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootEnemy : MonoBehaviour
{
    [SerializeField]
    private GameObject enemyBullet;
    [SerializeField]
    private Transform canna;
    [SerializeField]
    private Transform enemyParent;
    [SerializeField]
    private float maxTimer;
    [SerializeField]
    private float Timer;





    // Start is called before the first frame update
    void Start()
    {
        Timer = maxTimer;
    }

    // Update is called once per frame
    void Update()
    {              
        Shoot();
    }

    private void Shoot()
    {
        Timer -= Time.deltaTime;
        if (Timer <= 0)
        {
            Instantiate(enemyBullet, canna);
            Timer = maxTimer;
        }
    }
}
