using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart: MonoBehaviour
{
    public void Button_Restart ()
    {
        SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
    }
}