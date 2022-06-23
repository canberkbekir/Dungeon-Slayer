using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class getItem : MonoBehaviour
{
    PlayerShooting PlayerShooting;
    GameObject invetory;
    public GameObject currentItem;
    public int itemHitValue;



    public Text weaponNameText;
    public Text weaponAttackText;
    public Image weaponIcon;


    private void Start()
    {
        PlayerShooting = GameObject.Find("Player").GetComponent<PlayerShooting>();
        invetory = GameObject.Find("Inventory");

        weaponNameText = GameObject.Find("Weapon Name").GetComponent<Text>();
        weaponAttackText = GameObject.Find("Weapon Attack").GetComponent<Text>();
        weaponIcon = GameObject.Find("Weapon Icon").GetComponent<Image>();

        currentItem = invetory.GetComponent<DevionGames.InventorySystem.ItemCollection>().m_Items[1].Prefab;
        itemHitValue = invetory.GetComponent<DevionGames.InventorySystem.ItemCollection>().m_Items[1].FindProperty("Attack").intValue;


        weaponNameText.text = invetory.GetComponent<DevionGames.InventorySystem.ItemCollection>().m_Items[1].name.ToString();
        
    }

    private void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.Keypad1) && invetory.GetComponent<DevionGames.InventorySystem.ItemCollection>().m_Items[1] != null)
        {
            Debug.Log(invetory.GetComponent<DevionGames.InventorySystem.ItemCollection>().m_Items[1].FindProperty("Attack").intValue.ToString());
            currentItem = invetory.GetComponent<DevionGames.InventorySystem.ItemCollection>().m_Items[1].Prefab;
            itemHitValue = invetory.GetComponent<DevionGames.InventorySystem.ItemCollection>().m_Items[1].FindProperty("Attack").intValue;
            Debug.Log(invetory.GetComponent<DevionGames.InventorySystem.ItemCollection>().m_Items[1].FindProperty("Attack").intValue);
            weaponNameText.text = invetory.GetComponent<DevionGames.InventorySystem.ItemCollection>().m_Items[1].name.ToString();
            weaponAttackText.text = itemHitValue.ToString();
            weaponIcon.sprite = invetory.GetComponent<DevionGames.InventorySystem.ItemCollection>().m_Items[1].Icon;


        }
        else if (Input.GetKeyDown(KeyCode.Keypad2) && invetory.GetComponent<DevionGames.InventorySystem.ItemCollection>().m_Items[2] != null)
        {
            Debug.Log(invetory.GetComponent<DevionGames.InventorySystem.ItemCollection>().m_Items[2].FindProperty("Attack").intValue.ToString());
            currentItem = invetory.GetComponent<DevionGames.InventorySystem.ItemCollection>().m_Items[2].Prefab;
            itemHitValue = invetory.GetComponent<DevionGames.InventorySystem.ItemCollection>().m_Items[2].FindProperty("Attack").intValue;

            weaponNameText.text = invetory.GetComponent<DevionGames.InventorySystem.ItemCollection>().m_Items[2].name.ToString();
            weaponAttackText.text = itemHitValue.ToString();
            weaponIcon.sprite = invetory.GetComponent<DevionGames.InventorySystem.ItemCollection>().m_Items[2].Icon;


        }
        else if(Input.GetKeyDown(KeyCode.Keypad3) && invetory.GetComponent<DevionGames.InventorySystem.ItemCollection>().m_Items[3] != null)
        {
            Debug.Log(invetory.GetComponent<DevionGames.InventorySystem.ItemCollection>().m_Items[3].FindProperty("Attack").intValue.ToString());
            currentItem = invetory.GetComponent<DevionGames.InventorySystem.ItemCollection>().m_Items[3].Prefab;
            itemHitValue = invetory.GetComponent<DevionGames.InventorySystem.ItemCollection>().m_Items[3].FindProperty("Attack").intValue;

            weaponNameText.text = invetory.GetComponent<DevionGames.InventorySystem.ItemCollection>().m_Items[3].name.ToString();
            weaponAttackText.text = itemHitValue.ToString();
            weaponIcon.sprite = invetory.GetComponent<DevionGames.InventorySystem.ItemCollection>().m_Items[3].Icon;

        }
        else if (Input.GetKeyDown(KeyCode.Keypad4) && invetory.GetComponent<DevionGames.InventorySystem.ItemCollection>().m_Items[4] != null)
        {
            Debug.Log(invetory.GetComponent<DevionGames.InventorySystem.ItemCollection>().m_Items[4].FindProperty("Attack").intValue.ToString());
            currentItem = invetory.GetComponent<DevionGames.InventorySystem.ItemCollection>().m_Items[4].Prefab;
            itemHitValue = invetory.GetComponent<DevionGames.InventorySystem.ItemCollection>().m_Items[4].FindProperty("Attack").intValue;

            weaponNameText.text = invetory.GetComponent<DevionGames.InventorySystem.ItemCollection>().m_Items[4].name.ToString();
            weaponAttackText.text = itemHitValue.ToString();
            weaponIcon.sprite = invetory.GetComponent<DevionGames.InventorySystem.ItemCollection>().m_Items[4].Icon;

        }
        else if (Input.GetKeyDown(KeyCode.Keypad5) && invetory.GetComponent<DevionGames.InventorySystem.ItemCollection>().m_Items[5] != null)
        {
            Debug.Log(invetory.GetComponent<DevionGames.InventorySystem.ItemCollection>().m_Items[5].FindProperty("Attack").intValue.ToString());
            currentItem = invetory.GetComponent<DevionGames.InventorySystem.ItemCollection>().m_Items[5].Prefab;
            itemHitValue = invetory.GetComponent<DevionGames.InventorySystem.ItemCollection>().m_Items[5].FindProperty("Attack").intValue;

            weaponNameText.text = invetory.GetComponent<DevionGames.InventorySystem.ItemCollection>().m_Items[5].name.ToString();
            weaponAttackText.text = itemHitValue.ToString();
            weaponIcon.sprite = invetory.GetComponent<DevionGames.InventorySystem.ItemCollection>().m_Items[5].Icon;

        }
        else if (Input.GetKeyDown(KeyCode.Keypad6) && invetory.GetComponent<DevionGames.InventorySystem.ItemCollection>().m_Items[6] != null)
        {
            Debug.Log(invetory.GetComponent<DevionGames.InventorySystem.ItemCollection>().m_Items[6].FindProperty("Attack").intValue.ToString());
            currentItem = invetory.GetComponent<DevionGames.InventorySystem.ItemCollection>().m_Items[6].Prefab;
            itemHitValue = invetory.GetComponent<DevionGames.InventorySystem.ItemCollection>().m_Items[6].FindProperty("Attack").intValue;

            weaponNameText.text = invetory.GetComponent<DevionGames.InventorySystem.ItemCollection>().m_Items[6].name.ToString();
            weaponAttackText.text = itemHitValue.ToString();
            weaponIcon.sprite = invetory.GetComponent<DevionGames.InventorySystem.ItemCollection>().m_Items[6].Icon;

        }
        else if (Input.GetKeyDown(KeyCode.Keypad7) && invetory.GetComponent<DevionGames.InventorySystem.ItemCollection>().m_Items[7] != null)
        {
            Debug.Log(invetory.GetComponent<DevionGames.InventorySystem.ItemCollection>().m_Items[7].FindProperty("Attack").intValue.ToString());
            currentItem = invetory.GetComponent<DevionGames.InventorySystem.ItemCollection>().m_Items[7].Prefab;
            itemHitValue = invetory.GetComponent<DevionGames.InventorySystem.ItemCollection>().m_Items[7].FindProperty("Attack").intValue;

            weaponNameText.text = invetory.GetComponent<DevionGames.InventorySystem.ItemCollection>().m_Items[7].name.ToString();
            weaponAttackText.text = itemHitValue.ToString();
            weaponIcon.sprite = invetory.GetComponent<DevionGames.InventorySystem.ItemCollection>().m_Items[7].Icon;

        }
        
        

    }

}
