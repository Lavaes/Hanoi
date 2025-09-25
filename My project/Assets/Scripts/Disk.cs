using UnityEngine;

public class Disk : MonoBehaviour
{
    [SerializeField] float width;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void Move(float x, float y)
    {
        transform.position = new Vector2(Unity)
    }
    public float GetWidth() {
        return width;
    }
}
