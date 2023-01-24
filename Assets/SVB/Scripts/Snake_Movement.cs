using TMPro;
using UnityEngine;

public class Snake_Movement: MonoBehaviour
{
    public float ForwardSpeed = 5;
    public float Sensitivity = 10;

    public int Length = 1;

    public TextMeshPro PointsText;

    private Camera Main_Camera;
    private Rigidbody Component_Rigidbody;
    private Tail Component_Tail;

    private Vector3 Touch_Last_Pos;
    private float Sideways_Speed;

    private void Start ()
    {
        int i;
        Main_Camera = Camera.main;
        Component_Rigidbody = GetComponent <Rigidbody> ();
        Component_Tail = GetComponent <Tail> ();

        for (i = 0; i < Length; i++)
            Component_Tail.Add_Circles ();

        PointsText.SetText (Length.ToString ());
    }

    private void Update ()
    {
        if (Input.GetMouseButtonDown (0))
        {
            Touch_Last_Pos = Main_Camera.ScreenToViewportPoint (Input.mousePosition);
        }

        else if (Input.GetMouseButtonUp (0))
        {
            Sideways_Speed = 0;
        }

        else if (Input.GetMouseButton (0))
        {
            Vector3 delta = (Vector3) Main_Camera.ScreenToViewportPoint (Input.mousePosition) - Touch_Last_Pos;
            Sideways_Speed += delta.x * Sensitivity;
            Touch_Last_Pos = Main_Camera.ScreenToViewportPoint (Input.mousePosition);
        }

        if (Input.GetKeyDown (KeyCode.A))
        {
            Length++;
            Component_Tail.Add_Circles ();
            PointsText.SetText (Length.ToString ());
        }

        if (Input.GetKeyDown (KeyCode.D))
        {
            Length--;
            Component_Tail.Remove_Circle ();
            PointsText.SetText (Length.ToString ());
        }
    }

    private void FixedUpdate ()
    {
        if (Mathf.Abs (Sideways_Speed) > 4)
            Sideways_Speed = 4 * Mathf.Sign (Sideways_Speed);
        Component_Rigidbody.velocity = new Vector3 (Sideways_Speed * 5, ForwardSpeed);

        Sideways_Speed = 0;
    }
}
