using UnityEngine;
using UnityEngine.SceneManagement;

public class levelcomplete : MonoBehaviour
{
    public void Loadnextlevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
