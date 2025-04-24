using UnityEngine;

public class MoveCubeHomework : MonoBehaviour

{
    public Vector3 newScale = new Vector3(100f, 40f, 587f);
    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = newScale;    
    }

    // Update is called once per frame
    void Update()
    {
    }
}
