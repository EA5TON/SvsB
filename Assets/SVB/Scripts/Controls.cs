using UnityEngine;

public class Controls: MonoBehaviour
{
    public float Speed;

    public bool Arrow;
    public bool Mouse;

    //------------------------------------------------------------------------------------------------------------------------
    void FixedUpdate ()
    {
        Change_Control ();
    }
    //------------------------------------------------------------------------------------------------------------------------
    void Change_Control ()
    {
        if (Arrow == true && Mouse == false)
            Arrow_Control ();

        else if (Mouse == true && Arrow == false)
            Mouse_Control ();

        else if (Arrow == true && Mouse == true)
        {
            Arrow_Control ();
            Mouse_Control ();
        }
    }
    //------------------------------------------------------------------------------------------------------------------------
    void Arrow_Control ()
    {
        Vector3 arrow;
        float speed = Speed * Time.deltaTime;

        if (Input.GetKey (KeyCode.LeftArrow))
        {
            arrow = new (-speed, 0, 0);
            transform.Translate (arrow * speed);
        }

        else if (Input.GetKey (KeyCode.RightArrow))
        {
            arrow = new (speed, 0, 0);
            transform.Translate (arrow * speed);
        }

        else if (Input.GetKey (KeyCode.UpArrow))
        {
            arrow = new (0, 0, speed);
            transform.Translate (arrow * speed);
        }

        else if (Input.GetKey (KeyCode.DownArrow))
        {
            arrow = new (0, 0, -speed);
            transform.Translate (arrow * speed);
        }
    }
    //------------------------------------------------------------------------------------------------------------------------
    void Mouse_Control ()
    {
        Vector3 mouse;
        float multiplier = 2;
        float mouse_speed = (Speed * multiplier) * Time.deltaTime;

        if (Input.GetMouseButton (0))
        {
            mouse = new (Input.GetAxis ("Mouse X") * mouse_speed, 0, 0);
            transform.Translate (((Speed * multiplier) * mouse) * Time.deltaTime);
        }
    }
    //------------------------------------------------------------------------------------------------------------------------
}