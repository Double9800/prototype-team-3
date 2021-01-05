using UnityEngine;

public class CannaMovement : MonoBehaviour
{
    [SerializeField] GameObject canna;
    [SerializeField] GameObject mira;
    [SerializeField] Transform mirino;
    void Start()
    {

    }


    void Update()
    {
        Vector3 aimDirection = mira.transform.position - canna.transform.position;
        canna.transform.rotation = Quaternion.LookRotation(aimDirection);
    }
}
