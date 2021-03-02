using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;

public class TileMenejer : MonoBehaviour
{
    public GameObject[] tilePrefeb;

    private Transform playerTransform;
    private float spwanZ = 50.0f;
    private int tileLenght = 100;
    private int TileOnScreen = 4;
    private float safeZone = 150.0f;
    private int lasPrefebIndex = 0;
    private List<GameObject> activeTile;
    void Start()
    {
        activeTile = new List<GameObject>();

        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        for (int i = 0; i < TileOnScreen; i++)
        {
            if (i < 2)
                spwanTile(0);
            else
                spwanTile();
                
        }
    }

    
    void Update()
    {
        if (playerTransform.position.z-safeZone>(spwanZ-TileOnScreen*tileLenght))
        {
            spwanTile();
            deleteTile();
        }
    }
    private void spwanTile(int prefIndex=-1)
    {
        GameObject go;
        if (prefIndex==-1)
        {
         go = Instantiate(tilePrefeb[RandomPrefebIndex()]) as GameObject;
        }
        else
        {
            go = Instantiate(tilePrefeb[prefIndex]) as GameObject;
        }
        go.transform.SetParent(transform);
        go.transform.position = Vector3.forward * spwanZ;
        spwanZ += tileLenght;
        activeTile.Add(go);
    }

    private void deleteTile()
    {
        Destroy(activeTile[0]);
        activeTile.RemoveAt(0);
    }

    private int RandomPrefebIndex()
    {
        if (tilePrefeb.Length<=1)
        {
            return 0;
        }
        int randomIndex = lasPrefebIndex;
        while (randomIndex==lasPrefebIndex)
        {
            randomIndex = Random.Range(0, tilePrefeb.Length);
        }
        lasPrefebIndex = randomIndex;
        return randomIndex;
    }
}
