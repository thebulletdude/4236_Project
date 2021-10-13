using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    private bool dragging;
    private Vector3 returnLocation;
    private Vector3 mousePosition;
    public GameObject controller;
    public GameObject sprite;
    // Start is called before the first frame update
    void Start()
    {
        controller = GameObject.Find("Controller");
        dragging = false;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseOver()
    {
        transform.localScale = new Vector3(1.5f, 1.5f, 1);

    }

    private void OnMouseExit()
    {
        if (!dragging)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        
    }
    
    private void OnMouseDrag()
    {
        dragging = true;
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 10;
        transform.position = mousePosition;
   
    }

    private void OnMouseDown()
    {
        returnLocation = transform.position;
    }

    private void OnMouseUp()
    {
        if (!controller.GetComponent<Controller>().inSpot || controller.GetComponent<Controller>().checkTaken())
        {
            transform.position = returnLocation;
        }
        else
        {
            
            sprite = Instantiate(sprite, controller.GetComponent<Controller>().currentTile, Quaternion.identity);
            controller.GetComponent<Controller>().addEntity(sprite);
            Destroy(gameObject);
        }
        dragging = false;

    }
}
