using UnityEngine;

public class Camera_Follow: MonoBehaviour
{
    public GameObject Ball;
    private Vector3 Moving;

    void Start ()
    {
        Moving = transform.position - Ball.transform.position;
    }

    void Update ()
    {
        transform.position = Ball.transform.position + Moving;
    }
}