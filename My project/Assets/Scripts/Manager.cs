using Unity.Multiplayer.Center.Common;
using UnityEngine;
using UnityEngine.UI;


public class Manager : MonoBehaviour
{
    [SerializeField] Text movesText;
    public int moves = 0;
    [SerializeField] Disk[] disks;
    [SerializeField] Pole[] poles;
    private bool finished = false;
    public int selectedPole = -1;
    [SerializeField] Text gameWin;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            disks[i].Reset(); // go all back to list in order
        }
        moves = 0;
        finished = false;

    }

    // Update is called once per frame
    void Update()
    {

    }
    // if selected pole = -1 or wtv, do the things
    // poleclicked(poleNumber) turns the pole on with different color here
    // have another int selected pole for previous pole -- compare to new selected pole
    // btw when you click the same pole twice (same as selectedpole when comparing) change it to unselected and do nothing
    // layers: give winText layer 2 (top when it appears)
    public void PoleClicked(int poleNumber)
    {
        if (selectedPole == -1)
        {
            selectedPole = poleNumber;
            poles[selectedPole].GetComponent<Renderer>().material.color = Color.gray;
        }
        else if (selectedPole == poleNumber)
        {
            poles[selectedPole].GetComponent<Renderer>().material.color = Color.white;
            selectedPole = -1; // unselect
        }
        else if (selectedPole != -1 && selectedPole != poleNumber)
        {
            poles[selectedPole].GetComponent<Renderer>().material.color = Color.white;
            MoveDisk(selectedPole, poleNumber); // from, to
            selectedPole = -1;
        }
    }
    // pole 1: x = -3.5, pole 2: x = 0, pole 3: x = 3.5
    // bottom disk: y = -2.1, y = -1.65, y = -1.2, y = -0.75, y = -0.3
    public void MoveDisk(int from, int to)
    {
        moves++;

    }
}
