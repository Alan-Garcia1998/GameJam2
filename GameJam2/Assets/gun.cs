
using UnityEngine;

public class gun : MonoBehaviour
{
    public Camera fpsCam;
    public float num = 200f;//public bool fLoat = false;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<ConstantForce>().relativeForce = new Vector3(0, -10, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            shoot();

           
        }
    }


    void shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit))
        {
            Debug.Log(hit.transform.name);
            num = num * -1;
            GetComponent<ConstantForce>().relativeForce = new Vector3(0, num, 0);
        }
    }
}