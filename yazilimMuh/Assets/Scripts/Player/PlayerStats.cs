using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{

    public Text playerHealthText;

    public float playerHealthStat = 100;
    public float playerAttackStat = 10;
    public float playerCoins = 100;

    GameObject invetory;

    public float playerCurrentHealth;


    private void Start()
    {

        playerHealthText = GameObject.Find("Health").GetComponent<Text>();
        invetory = GameObject.Find("Inventory");
        playerCurrentHealth = playerHealthStat;
    }

    private void Update()
    {
        playerCoins = invetory.GetComponent<DevionGames.InventorySystem.ItemCollection>().m_Items[0].Stack;
        playerHealthText.text = playerCurrentHealth.ToString();
    }

    void Death()
    {
        if(playerCurrentHealth <= 0)
        {
            //DEATH
        }
    }



    


}
