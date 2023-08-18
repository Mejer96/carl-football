using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowPauseMenu : MonoBehaviour
{
    public GameObject _pauseMenu;
    bool isPaused = false;

    // Start is called before the first frame update
    void Start()
    {
        _pauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("escape"))
        {
          if (!isPaused)
            {
                _pauseMenu.SetActive(true);
                isPaused = true;
            } else
            {
                _pauseMenu.SetActive(false);
                isPaused = false;
            }
        }

        
     }
   
}
