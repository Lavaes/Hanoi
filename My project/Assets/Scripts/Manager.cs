using System.Collections.Generic;
using System.Linq;
using Unity.Multiplayer.Center.Common;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class Manager : MonoBehaviour
{
    [SerializeField] Text movesText;
    public int moves = 0;
    [SerializeField] Text winText;
    [SerializeField] Disk[] diskList = new Disk[5];
    [SerializeField] Pole[] poles = new Pole[3];
    private bool finished = false;
    public int selectedPole = -1;
    [SerializeField] Text gameWin;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        RenderPoles();
        moves = 0;
        finished = false;
        selectedPole = -1;
    }

    // Update is called once per frame
    void Update()
    {
        IsWon();
        if (!finished)
        {
            winText.enabled = false;
        }
        else if (finished)
        {
            winText.enabled = true;
        }
            RenderPoles();
    }
    // if selected pole = -1 or wtv, do the things
    // poleclicked(poleNumber) turns the pole on with different color here
    // have another int selected pole for previous pole -- compare to new selected pole
    // btw when you click the same pole twice (same as selectedpole when comparing) change it to unselected and do nothing
    // layers: give winText layer 2 (top when it appears)


    // give all objects appropriate managers and stuff
    public void PoleClicked(int poleNumber)
    {
        if (selectedPole == -1)
        {
            selectedPole = poleNumber;
            //poles[selectedPole].GetComponent<Renderer>().material.color = Color.gray;
        }
        else if (selectedPole == poleNumber)
        {
            //poles[selectedPole].GetComponent<Renderer>().material.color = Color.white;
            selectedPole = -1; // unselect
        }
        else if (selectedPole != -1 && selectedPole != poleNumber)
        {
            //poles[selectedPole].GetComponent<Renderer>().material.color = Color.white;
            MoveDisk(selectedPole-1 , poleNumber-1); // from, to
            selectedPole = -1;
        }
    }
    // pole 1: x = -3.5, pole 2: x = 0, pole 3: x = 3.5
    // bottom disk: y = -2.1, y = -1.65, y = -1.2, y = -0.75, y = -0.3
    public void MoveDisk(int from, int to)
    {
        moves++;
        int maxFrom = poles[from].disks.Count - 1;
        int maxTo = poles[to].disks.Count - 1;
        if (maxFrom > -1 && maxTo < 4)
        {
            // "layer" of disks to compare are from 0 to 4
            if (maxTo == -1 || poles[from].disks[maxFrom].GetLayer() < poles[to].disks[maxTo].GetLayer())
            {
                poles[to].disks.Add(poles[from].disks[maxFrom]);
                poles[from].disks.Remove(poles[from].disks[maxFrom]); // swap
            }
        }
    }
    public Disk[] allDisks()
    {
        return diskList;
    }
    public void RenderPoles()
    {
        for (int i = 0; i < poles.Length; i++)
        {
            float x;
            if (i == 0) x = -3.5f;
            else if (i == 1) x = 0f;
            else x = 3.5f;
            float y = -2.1f - 0.45f;
            for (int j = 0; j < poles[i].disks.Count; j++)
            {
                y = y + 0.45f;
                poles[i].disks[j].transform.position = new Vector3(x, y, 0f); // should put it at the correct positions
            }
                    
        }
    }
    public void IsWon ()
    {
        if (poles[2].disks.Count == 5)
        {
            finished = true;

        }
    }
}
