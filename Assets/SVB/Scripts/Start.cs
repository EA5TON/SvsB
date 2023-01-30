using UnityEngine;

public class Start: MonoBehaviour
{
    [SerializeField] Controls Component_Forward_Speed;
    [SerializeField] internal GameObject Go;

    void Awake ()
    {
        Go.SetActive (true);
    }

    public void Button_Start ()
    {
        Go.SetActive (false);
        Component_Forward_Speed.Forward_Speed += 1;
    }
}
