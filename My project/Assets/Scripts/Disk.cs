using UnityEngine;

public class Disk : MonoBehaviour
{
    [SerializeField] GameObject manager;
    [SerializeField] float width; // assigned before
    [SerializeField] int layer; // assigned before

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public float GetWidth() {
        return width;
    }
    public int GetLayer()
    {
        return layer;
    }
    public void Reset()
    {
        
    }
}
