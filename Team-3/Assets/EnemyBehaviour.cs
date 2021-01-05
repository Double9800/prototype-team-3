using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    [SerializeField] GameObject canna;
    [SerializeField] GameObject player;
    [SerializeField] Transform tPlayer;
    Vector3 targetDirection;
    [SerializeField] ShootEnemy myScript;


    private void OnTriggerEnter(Collider other)
    {
        Vector3 targetDirection = tPlayer.transform.position - canna.transform.position;
        if (other.gameObject.CompareTag("Player"))
        {
            myScript.enabled = true;
            canna.transform.rotation = Quaternion.LookRotation(targetDirection);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        Vector3 targetDirection = tPlayer.transform.position - canna.transform.position;
        if (other.gameObject.CompareTag("Player"))
        {
            canna.transform.rotation = Quaternion.LookRotation(targetDirection);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        //Vector3 targetDirection = tPlayer.transform.position - canna.transform.position;
        if (other.gameObject.CompareTag("Player"))
        {
            myScript.enabled = false;
            
        }
    }

}
