using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
    


{
    private void Start()
    {
        Time.timeScale = 0.0f;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            Time.timeScale = 1.0f;
        }
        else if (Input.GetKeyDown(KeyCode.Z))
            Time.timeScale = 1.0f;
        }
    }