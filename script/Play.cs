using UnityEngine;
using UnityEngine.SceneManagement;


public class Play : MonoBehaviour
{
    public void startG()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
