using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame. 
   // void Update()
    //{

//    }

    // freshly handmade method. 
    // Compare with the Start method which is not public. 
    // A public method can be called from other GameObjects!
    public void GoToGame()
    {
        SceneManager.LoadScene("Game");
    }
}
