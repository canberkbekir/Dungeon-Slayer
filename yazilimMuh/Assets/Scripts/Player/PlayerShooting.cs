using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    RaycastHit hit;
    [SerializeField]
    Transform playerCamera;
    [SerializeField]
    Transform hand;
    [SerializeField] float interactionDistance = 10f;
    private void Awake()
    {
        //Scene yüklendiğinde Level'da player'ın "Head" gameobjectini arayıp buluyor.
        playerCamera = GameObject.Find("/Player Camera/Main Camera").transform;
    }

    void Update()
    {
        //Raycast çekiliyor.
        if (Physics.Raycast(playerCamera.position, playerCamera.TransformDirection(Vector3.forward), out hit, interactionDistance))
        {
            Debug.DrawRay(playerCamera.position, playerCamera.TransformDirection(Vector3.forward) * interactionDistance, Color.yellow);
            Debug.Log(hit);
        }
    }
}
