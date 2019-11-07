using UnityEngine;

public class ball : MonoBehaviour {

    [Range(20, 1000)]
    public float speed = 30;
    [Range(20, 1000)]
    public int jump = 30;
    Rigidbody RRR;
    public bool groundornot;


    private void Start()
    {

        RRR = this.GetComponent<Rigidbody>();

    }

    private void OnCollisionEnter(Collision collision)
    {
        groundornot = true;
    }

    private void Update()
    {
        walk();
        jujump();
    }

    private void walk()
    {

        RRR.AddForce(new Vector3(speed * Input.GetAxis("Horizontal"), 0, 0));
        RRR.AddForce(new Vector3(0, 0, speed * Input.GetAxis("Vertical")));

    }

    private void jujump()
    {

        if (Input.GetKeyDown(KeyCode.Space) && groundornot == true)
        {
            groundornot = false;
            RRR.AddForce(new Vector3(0, jump, 0));
        }

    }

}
