using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;


public class EscGame : MonoBehaviour
{
    public string sceneName;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("escape key was pressed");

            SceneManager.LoadScene(sceneName);
            Debug.Log("Changed scene to " + sceneName);
        }
    }

}
