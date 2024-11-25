using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset= transform.position-player.transform.position;
    }

    // Update is called once per frame
    //LateUpdate runs only after each and every update has run
    void LateUpdate()
    {
        transform.position=offset+player.transform.position;
    }
}
