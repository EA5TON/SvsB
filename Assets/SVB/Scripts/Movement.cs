using UnityEngine;

public class Movement: MonoBehaviour
{
    public float Speed = 1.0f;
    public Vector3 Impulse;

    private Rigidbody RB;

    void Awake ()
    {
        RB = GetComponent <Rigidbody> ();
    }

    void Start ()
    {
        RB.AddForce (Impulse, ForceMode.Impulse);
    }

    void FixedUpdate ()
    {
        //if (Input.GetKey (KeyCode.UpArrow))
            transform.position += Speed * Time.deltaTime * transform.forward;
        //else if (Input.GetKey (KeyCode.DownArrow))
        //    transform.position -= transform.forward * Speed * Time.deltaTime;
    }
}