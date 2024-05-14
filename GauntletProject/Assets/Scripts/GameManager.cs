using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Rendering;

public class GameManager : Singleton<GameManager>
{
    public int currentScore;
    public int highScore;
    public int dungeonLevel;
    public int playerHealth;

    public float time;
    public float timeDelay;

    public TMPro.TextMeshProUGUI dialouge;
    public TMPro.TextMeshProUGUI scoreText;
    public TMPro.TextMeshProUGUI dungeonText;
    public TMPro.TextMeshProUGUI hpText;

    public GameObject itemPickUp;
    public GameObject keyUI;
    public GameObject potionUI;

    public bool hasKey;

    public bool hasPotion;

    public void Start()
    {
        currentScore = 0;
        dungeonLevel = 1;
        playerHealth = 2000;
        time = 0f;
        timeDelay = 0.5f;
        hasKey = false;
        hasPotion = false;
    }

    public void Update()
    {
        Display();
        HPLossDelay();
        KeyThing();
        PotionThing();
    }

    private void Display()
    {
        scoreText.text = "Score: " + currentScore;
        hpText.text = "Health: " + playerHealth;
    }

    private void HPLossDelay()
    {
        time = time + 1f * Time.deltaTime;
        if (time >= timeDelay)
        {
            time = 0f;
            playerHealth -= 1;
        }
    }

    private void Narrator() 
    {
    
    }

    private void SpawnDungeonLevel()
    {

    }

    private void SpawnPickUpItem()
    {

    }

    public IEnumerator hpLossDelay()
    {
        yield return new WaitForSeconds(1);
        playerHealth -= 1;
        yield return new WaitForSeconds(1);
    }

    public void KeyThing()
    {
        if (!hasKey)
        {
            keyUI.SetActive(false);
        }
        else
        {
            keyUI.SetActive(true);
        }
    }

    public void PotionThing()
    {
        if (!hasPotion)
        {
            potionUI.SetActive(false);
        }
        else
        {
            potionUI.SetActive(true);
        }
    }
}
