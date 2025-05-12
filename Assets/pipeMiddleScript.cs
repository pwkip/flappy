using UnityEngine;

public class pipeMiddleScript : MonoBehaviour
{

    public uiscript uiScript;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Start()
    {
        uiScript = GameObject.FindGameObjectWithTag("UI").GetComponent<uiscript>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            uiScript.AddScore();
        }

    }
}
