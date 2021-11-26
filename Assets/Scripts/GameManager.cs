using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [System.NonSerialized]
    public int currentStageNum = 0;

    [SerializeField]
    string[] stageName;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextStage()
    {
        currentStageNum += 1;
        StartCoroutine(WaitForLoadScene());
    }

    IEnumerator WaitForLoadScene()
    {
        yield return SceneManager.LoadSceneAsync(stageName[currentStageNum]);
    }
}
