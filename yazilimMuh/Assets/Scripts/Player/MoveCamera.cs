using UnityEngine;

public class MoveCamera : MonoBehaviour
{

    public Transform player;

    private void Awake()
    {
        //Scene yüklendiğinde Level'da player'ın "Head" gameobjectini arayıp buluyor.
        player = GameObject.Find("/Player/Head").transform;

    }
    void Update()
    {
        transform.position = player.transform.position;
    }
}