using UnityEngine;

public class Pole : MonoBehaviour
{
    public bool selected;
    [SerializeField] int poleNumber; // 1, 2, 3
    public Disk[] disks;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (poleNumber == 1)
        {

        }
    }

    // Update is called once per frame
    void Update()
    {
        if (IsSelected())
        {

        }
    }
    bool IsSelected()
    {
        return selected;
    }
    public void OnMouseDown() {
        //Manager.PoleClicked(poleNumber);

    }
    // send pole number to manager, tell it that someone clicked it, and have the manager move the disks and stuff
}
