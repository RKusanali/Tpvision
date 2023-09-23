using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MondetoDragon : MonoBehaviour
{
    private string nextSceneName = "DragonHouse";
    public GameObject item;
    public int setInterval = 70;
    public float ninimun_distance = 2.0f;
    public Transform playerTransform;
    UIBehaviour uiBehaviour;

    // Start is called before the first frame update
    void Start()
    {
        uiBehaviour = GetComponent<UIBehaviour>();
    }

    // Update is called once per frame
    private void Update()
    {
        if ((setInterval>uiBehaviour.gettime()) && (Vector3.Distance(playerTransform.position, item.transform.position) < ninimun_distance))
        {
            SceneManager.LoadScene(nextSceneName);
        }
    }
}
