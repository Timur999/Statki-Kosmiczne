using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScripts : MonoBehaviour
{

   public void Zaczynamy()
   {
        SceneManager.LoadScene("Game");
   }

    public void Zamykanie()
    {
        Application.Quit();
        Debug.Log("Zamykanie");
    }
}
