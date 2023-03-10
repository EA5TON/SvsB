using UnityEngine;

public class Camera_Follow: MonoBehaviour
{
    float Offset;

    [SerializeField] GameObject Ball;

    //------------------------------------------------------------------------------------------------------------------------
    public void Awake ()
    {
        Offset = transform.position.z - Ball.transform.position.z;
    }
    //------------------------------------------------------------------------------------------------------------------------
    public void Update ()
    {
        Vector3 cam_pos = transform.position;
        cam_pos.z = Ball.transform.position.z + Offset;
        transform.position = cam_pos;
    }
    //------------------------------------------------------------------------------------------------------------------------
}