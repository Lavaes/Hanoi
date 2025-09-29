using System;
using System.Collections.Generic;
using UnityEngine;

public class Pole : MonoBehaviour
{
    [SerializeField] GameObject manager;
    public bool selected;
    [SerializeField] int poleNumber; // 1, 2, 3
    public List<Disk> disks;
    public Color poleColor = Color.white;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        if (poleNumber == 1)
        {
            // place all disks
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (IsSelected())
        {
            this.GetComponent<Renderer>().material.color = Color.gray;
        }
        else this.GetComponent<Renderer>().material.color = Color.white;
    }
    bool IsSelected()
    {
        if (manager.GetComponent<Manager>().selectedPole == poleNumber)
        {
            selected = true;
        }
        else return false;
        return selected;
    }
    public void OnMouseDown()
    { // add a collider
        Debug.Log(poleNumber);
        manager.GetComponent<Manager>().PoleClicked(poleNumber);
        
    }
    // send pole number to manager, tell it that someone clicked it, and have the manager move the disks and stuff
}
