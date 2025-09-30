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
            disks.Add(manager.GetComponent<Manager>().allDisks()[4]);
            disks.Add(manager.GetComponent<Manager>().allDisks()[3]);
            disks.Add(manager.GetComponent<Manager>().allDisks()[2]);
            disks.Add(manager.GetComponent<Manager>().allDisks()[1]);
            disks.Add(manager.GetComponent<Manager>().allDisks()[0]);
        }
        else disks.Clear();
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
    public void Reset()
    {
        if (poleNumber == 1)
        {
            disks.Add(manager.GetComponent<Manager>().allDisks()[4]);
            disks.Add(manager.GetComponent<Manager>().allDisks()[3]);
            disks.Add(manager.GetComponent<Manager>().allDisks()[2]);
            disks.Add(manager.GetComponent<Manager>().allDisks()[1]);
            disks.Add(manager.GetComponent<Manager>().allDisks()[0]);
        }
        else disks.Clear();
    }
    // send pole number to manager, tell it that someone clicked it, and have the manager move the disks and stuff
}
