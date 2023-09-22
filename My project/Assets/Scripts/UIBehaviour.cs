using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class UIBehaviour : MonoBehaviour
{
    TMP_Text headText;
    //int nbCats = 0;
    int nbHeads = 0;
    public Text timerText;
    private int currentTime = 600;

    void Start()
    {
        headText = GameObject.Find("lblCats").GetComponent<TMPro.TMP_Text>();
        StartCoroutine(TimerTick());
        currentTime = GameVariables.allowedTime;
    }
    void Update()
    {
    }

    public int getnb() { return nbHeads; }
    public int gettime() { return currentTime; }

    IEnumerator TimerTick()
    {
        while (currentTime > 0)
        {
            // attendre une seconde
            yield return new WaitForSeconds(1);
            currentTime--;
            timerText.text = "Time :" + currentTime.ToString();
        }
        // game over
        SceneManager.LoadScene("DragonHouse"); // le nom de votre scene
    }

    public void AddHit()
    {
        nbHeads++;
        headText.text = "BobHeads: " + nbHeads;
    }
}