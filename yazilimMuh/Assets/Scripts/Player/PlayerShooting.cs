using UnityEngine;

public class PlayerShooting : MonoBehaviour
{

    RaycastHit hit;
    [SerializeField]
    Transform playerCamera;
    [SerializeField]
    Transform hand;
    [SerializeField] float hitDistance = 10f;



    
    [SerializeField] getItem getItem;
    [SerializeField] GameObject handItem;
    
    
    private void Awake()
    {

        getItem = gameObject.GetComponent<getItem>();
        
        handItem = getItem.currentItem;
        hand = GameObject.Find("/Player/Orientation/Hand").transform;
        playerCamera = GameObject.Find("/Player Camera/Main Camera").transform;

    }


    void Update()
    {
        handItem = getItem.currentItem;

        //Raycast çekiliyor.
       hitMeele();


    }

    void hitMeele()
    {
        if (Physics.Raycast(playerCamera.position, playerCamera.TransformDirection(Vector3.forward), out hit, hitDistance))
        {
            Debug.DrawRay(playerCamera.position, playerCamera.TransformDirection(Vector3.forward) * hitDistance, Color.yellow);

            if(hit.transform.gameObject.tag == "Enemy" && Input.GetKeyDown(KeyCode.Mouse0))
            {
                int hitValue = gameObject.GetComponent<getItem>().itemHitValue;
                hit.transform.gameObject.GetComponent<Dragon>().TakeDamage(hitValue);
            }
            else if (hit.transform.gameObject.name == "MARKET" && Input.GetKeyDown(KeyCode.Mouse0))
            {
                hit.transform.gameObject.GetComponent<Market>().openMarket();
            }
        }
    }


    
}

    
