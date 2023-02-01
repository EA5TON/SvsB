using UnityEngine;
using UnityEngine.SceneManagement;

public class Start_Game: MonoBehaviour
{
    [SerializeField] GameObject Go;

    public void Button_Start ()
    {
        Go.SetActive (false);
        SceneManager.LoadScene (1);
    }
}
