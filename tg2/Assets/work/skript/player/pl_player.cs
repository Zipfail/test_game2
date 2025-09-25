using UnityEngine;

public class pl_player : PC
{

    [SerializeField] private Transform camera;
    [SerializeField] private float distanse_Hit;
    private string raykast_tag;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(camera.position, camera.forward, out hit, distanse_Hit))
        {
            raykast_tag = hit.transform.tag;
        }
    }
}
