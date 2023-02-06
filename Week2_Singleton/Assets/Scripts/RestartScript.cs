using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Restart()
    {
        GameManager.Instance.currentLevel = 0;
        GameManager.Instance.score = 0;
        WASDControl.Instance.rb2d.gameObject.SetActive(true);
        WASDControl.Instance.rb2d.position = new Vector2(0, 8);
        SceneManager.LoadScene(0);
    }
}
