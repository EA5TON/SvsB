using UnityEngine;

public class Score_Ball: MonoBehaviour
{
    float Offset_X;
    float Offset_Z;

    [SerializeField] GameObject Ball;

    //------------------------------------------------------------------------------------------------------------------------
    public void Awake ()
    {
        Offset_X = transform.position.x - Ball.transform.position.x;
        Offset_Z = transform.position.z - Ball.transform.position.z;
    }
    //------------------------------------------------------------------------------------------------------------------------
    public void Update ()
    {
        Vector3 cam_pos = transform.position;
        cam_pos.x = Ball.transform.position.x + Offset_X;
        cam_pos.z = Ball.transform.position.z + Offset_Z;
        transform.position = cam_pos;
    }
    //------------------------------------------------------------------------------------------------------------------------
}