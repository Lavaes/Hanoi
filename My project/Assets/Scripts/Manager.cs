using UnityEngine;
using UnityEngine.UI;


public class Manager : MonoBehaviour
{
    [SerializeField] Text movesText;
    public int moves = 0;
    //[SerializeField] Disk[] disks;
    [SerializeField] Pole[] poles;
    private bool finished = false;

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
}
