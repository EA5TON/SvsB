using UnityEngine;

public class Movement: MonoBehaviour
{
    public float Speed = 1.0f;
    private Rigidbody RB;

    //public GameObject Blocks;

    //void Start ()
    //{
    //    RB = GetComponent <Rigidbody> ();
    //}

    void FixedUpdate ()
    {
        //if (Input.GetKey (KeyCode.UpArrow))
            transform.position += transform.forward * Speed * Time.deltaTime;
        //else if (Input.GetKey (KeyCode.DownArrow))
        //    transform.position -= transform.forward * Speed * Time.deltaTime;
    }

    //void OnTriggerEnter (Collider other)
    //{
    //    if (other.gameObject.CompareTag ("PickUp"))
    //    {
    //        other.gameObject.SetActive (false);
    //        Destroy (Blocks);
    //    }
    //}
}