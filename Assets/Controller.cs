using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{

    public bool inSpot;
    public Vector3 currentTile;
    public int tileIndex;
    public GameObject[] cardSlotsLocations;
    public GameObject[] entities;
    public GameObject[] cards;
    // Start is called before the first frame update


    void Start()
    {
        entities = new GameObject[12];
    }

    public void addEntity(GameObject e)
    {
        entities[tileIndex] = e;
    }

    public bool checkTaken()
    {
        if (entities[tileIndex] == null)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    //Method of how to get rid of sprites on the field.
    private void destroySprites()
    {
        for (int i = 0; i < entities.Length; i++)
        {
            Destroy(entities[i]);
            entities[i] = null;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("spawn");
            for(int i = 0; i < cardSlotsLocations.Length; i++)
            {
                Instantiate(cards[0], cardSlotsLocations[i].transform.position, Quaternion.identity);
            }
            
        }

    }


}
