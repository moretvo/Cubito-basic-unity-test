using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public AudioSource backgroundBGM;
    public float timer = 2f;


    public AudioControl control;

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        backgroundBGM.Play();

    }
    public bool gameHasEnded = false;

    public GameObject completeLevelUI;
    public void CompleteLevel(){

        Debug.Log("FIN DE NIVEL");
        StartCoroutine (AudioControl.AudioFadeOut.FadeOut (backgroundBGM, 0.6f));
        completeLevelUI.SetActive(true);
    }

    public void EndGame()
    {
        if(gameHasEnded == false)
        {
            gameHasEnded=true;
            Debug.Log("CHOCASTE");
            StartCoroutine (AudioControl.AudioFadeOut.FadeOut (backgroundBGM, 1.2f));
            Invoke("Restart", timer);
        }
    }
    
}
