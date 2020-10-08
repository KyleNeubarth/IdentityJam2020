using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class switchScenes : MonoBehaviour
{
    private Vector3 homeView = new Vector3(0f, 1f, -1000f);
    private Vector3 browserView = new Vector3(-2000f, 1f, -1000f);
    private Vector3 historyView = new Vector3(-4000f, 1f, -1000f);
    private Vector3 callView = new Vector3(2000f, 1f, -1000f);
    private Vector3 choiceView = new Vector3(4000f, 1f, -1000f);
    private Vector3 socialView = new Vector3(2000f, 2000f, -1000f);
    private Vector3 postView = new Vector3(4000f, 2000f, -1000f);
    private Vector3 chatView = new Vector3(-2000f, 2000f, -1000f);

    private void Start()
    {
        GameObject.Find("Main Camera").GetComponent<Camera>();
    }

    public void GotoTutorialScene()
    {
        SceneManager.LoadScene("howToPlayScene");
    }

    public void GotoGameScene()
    {
        SceneManager.LoadScene("murdererHomeScene");
    }

    public void GotoHome()
    {
        GameObject.Find("Main Camera").transform.position = homeView;
    }

    public void GotoBrowser()
    {
        GameObject.Find("Main Camera").transform.position = browserView;
    }
    public void GotoHistory()
    {
        GameObject.Find("Main Camera").transform.position = historyView;
    }
    public void GotoCall()
    {
        GameObject.Find("Main Camera").transform.position = callView;
    }
    public void GotoChoice()
    {
        GameObject.Find("Main Camera").transform.position = choiceView;
    }
    public void GotoSocial()
    {
        GameObject.Find("Main Camera").transform.position = socialView;
    }
    public void GotoPost()
    {
        GameObject.Find("Main Camera").transform.position = postView;
    }
    public void GotoChat()
    {
        GameObject.Find("Main Camera").transform.position = chatView;
    }
}