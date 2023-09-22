using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class DragontoAdventure : MonoBehaviour
{
    private string nextSceneName = "SceneMonde";
    public GameObject dragon; 
    public static int catBotsToDestroy = 10;
    public float nininum_dist = 40.0f;
    public Transform playerTransform;
    UIBehaviour uiBehaviour;

    void Start()
    {
        uiBehaviour = GetComponent<UIBehaviour>();
    }

    // Update is called once per frame
    private void Update()
    {
        if ((Vector3.Distance(playerTransform.position, dragon.transform.position) < nininum_dist) 
            && (uiBehaviour.getnb() >= GameVariables.cattodestroy))
        {
            SceneManager.LoadScene(nextSceneName);
            catBotsToDestroy += 5;
            GameVariables.cattodestroy += 5;
        }
    }
}
