using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart: MonoBehaviour
{
    [SerializeField] Controls Component_Forward_Speed;
    [SerializeField] Start Component_Go;

    public void Button_Restart ()
    {
        SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
        Component_Go.Go.SetActive (false);
        Component_Forward_Speed.Forward_Speed += 1;
    }
}
