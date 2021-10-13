using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseOverTile : MonoBehaviour
{
    public GameObject controller; 

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseOver()
    {
        
    }
    

    private void OnMouseUp()
    {
        //GameObject player = GameObject.Find("Player");
        //player.transform.position = transform.position;
    }

    private void OnMouseEnter()
    {
        //From the name of the tile find the number by removing the word "point" so I can
        //reference where to put it into the array.
        controller.GetComponent<Controller>().inSpot = true;
        string index = gameObject.name.Remove(0, 5);
        
        controller.GetComponent<Controller>().tileIndex = System.Convert.ToInt32(index);
        controller.GetComponent<Controller>().currentTile = transform.position;
        

    }

    private void OnMouseExit()
    {
        controller.GetComponent<Controller>().inSpot = false;
    }
}
