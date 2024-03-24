using System.Collections;
using System.Collections.Generic;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public PlayableDirector cutsceneTimeline;
    public GameObject timelineFinished;
    public bool grabbedWatch = false;
    public string scenename;

    private void OnTriggerEnter(Collider collision)
    {
        this.gameObject.GetComponent<CapsuleCollider>().enabled = false;

        cutsceneTimeline = GetComponent<PlayableDirector>();
        cutsceneTimeline.Play();
        Debug.Log("play cutsceneTimeline");

        grabbedWatch = true;
        Debug.Log("grabbedWatch: " + grabbedWatch);
    }

    private void Update()
    {
        if (timelineFinished.activeSelf == true)
        {
            Debug.Log("sceneName to load: " + scenename);
            SceneManager.LoadScene(scenename);
        }
    }
}
