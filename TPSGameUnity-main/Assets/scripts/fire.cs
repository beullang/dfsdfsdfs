using UnityEngine;

public class fire : MonoBehaviour
{
    public GameObject gb;
    public Transform firepos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {

            var obj = Instantiate(gb, gb.transform.position, gb.transform.rotation);
            var objrb = obj.GetComponent<Rigidbody>();
            objrb.AddForce(new Vector3(0, 0, 100), ForceMode.Impulse);
        }
    }
}
