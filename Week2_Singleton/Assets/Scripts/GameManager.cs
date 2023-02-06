using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int score = 0;

    public int currentLevel = 0;

    public int targetScore = 5;
    
    void Awake()    // Called when the script is being loaded
    {
        if (Instance == null)   // Instance has not been set
        {
            DontDestroyOnLoad(gameObject);  // Don't destroy
            Instance = this;    // Set Instance
        }
        else // Instance is set
        {
            Destroy(gameObject);
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if (score == targetScore || Input.GetKey(KeyCode.Return))   // for debugging purpose
        if (score == targetScore) 
        {
            currentLevel++;
            SceneManager.LoadScene(currentLevel);
            score = 0;
        }
        
        // winner scene
        if (currentLevel == 2)
        {
            WASDControl.Instance.rb2d.gameObject.SetActive(false);
        }
    }
}
