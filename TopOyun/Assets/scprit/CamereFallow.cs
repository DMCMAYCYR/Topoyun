using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamereFallow : MonoBehaviour
{
    public Transform player;
    public Vector3 offest;
    void Update()
    {
        transform.position = player.position + offest;
    }
}
