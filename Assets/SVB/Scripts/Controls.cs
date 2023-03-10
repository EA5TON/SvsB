using UnityEngine;

public class Controls: MonoBehaviour
{
    [SerializeField] float Forward_Speed = 1;
    [SerializeField] float Speed;
    [SerializeField] float Multiplier = 6;
    [Space]
    [SerializeField] bool Arrow;
    [SerializeField] bool Mouse;
    [SerializeField] internal bool Die;

    //------------------------------------------------------------------------------------------------------------------------
    void FixedUpdate ()
    {
        Change_Control ();
        transform.position += Forward_Speed * Time.deltaTime * transform.forward;
    }
    //------------------------------------------------------------------------------------------------------------------------
    public void Change_Control ()
    {
        if (Arrow)
            Arrow_Control ();

        if (Mouse)
            Mouse_Control ();

        if (Die)
            Die_Control ();
    }
    //------------------------------------------------------------------------------------------------------------------------
    public void Arrow_Control ()
    {
        float speed = Speed * Time.deltaTime;

        var inputX = Input.GetAxis ("Horizontal");

        Vector3 arrow = speed * new Vector3 (inputX, 0, 0);
        transform.Translate (arrow);
    }
    //------------------------------------------------------------------------------------------------------------------------
    public void Mouse_Control ()
    {
        Vector3 mouse;
        float mouse_speed = (Speed * Multiplier) * Time.deltaTime;

        if (Input.GetMouseButton (0))
        {
            mouse = new (Input.GetAxis ("Mouse X") * mouse_speed, 0, 0);
            transform.Translate (((Speed * Multiplier) * mouse) * Time.deltaTime);
        }
    }
    //------------------------------------------------------------------------------------------------------------------------
    public void Die_Control ()
    {
        Forward_Speed = 0;
        Arrow = false;
        Mouse = false;
    }
    //------------------------------------------------------------------------------------------------------------------------
}