using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Market : MonoBehaviour
{
    public Button attackButton;
    public Button healthButton;

    public PlayerStats playerStats;

    public GameObject marketUI;


    
    private void Awake()
    {
        marketUI = GameObject.Find("Market UI");
        playerStats = GameObject.Find("Player").GetComponent<PlayerStats>();
        attackButton = GameObject.Find("Buy Attack").GetComponent<Button>();
        healthButton = GameObject.Find("Buy Health").GetComponent<Button>();
        closeMarket();
    }

    



    public void attackUpgrade()
    {
        if(playerStats.playerCoins > 10f)
        {
            playerStats.playerAttackStat += 10;
            playerStats.playerCoins -= 15;

        }
        else
        {
            Debug.Log("Yeterli altin yok");
        }
    }

    public void healthUpgrade()
    {
        if (playerStats.playerCoins > 10f)
        {
            playerStats.playerHealthStat += 10;
            playerStats.playerCoins -= 15;

        }
        else
        {
            Debug.Log("Yeterli altin yok");
        }
    }

    public void closeMarket()
    {
        marketUI.SetActive(false);
    }

    public void openMarket()
    {
        marketUI.SetActive(true);
    }

    

}
