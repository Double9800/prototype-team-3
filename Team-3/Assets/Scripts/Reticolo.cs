using UnityEngine;

public class Reticolo : MonoBehaviour
{
    [Header("Input properties")]
    public Camera camera;

    private Vector3 reticlePosition;
    public Vector3 ReticlePosition
    {
        get { return reticlePosition; }
    }
    private Vector3 reticlenormal;
    public Vector3 ReticleNosition
    {
        get { return reticlenormal; }
    }


    void Update()
    {

    }

    protected virtual void HandleInputs()
    {
        Ray screenRay = camera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(screenRay, out hit))
        {
            reticlePosition = hit.point;
            reticleNormal = hit.normal;
        }
    }
}
