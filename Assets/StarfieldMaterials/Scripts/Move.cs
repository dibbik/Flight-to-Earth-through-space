using UnityEngine; 
using System.Collections;

public class Move : MonoBehaviour
{
    float Target;
	float speed = 0.01f;
	Rigidbody rigidbody;
	float horizontal;
	float vertical;


	void Start()
	{
		rigidbody = GetComponent<Rigidbody>();
	}

	void Update()
	{
        //Target += Time.deltaTime / 125;

        //transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, transform.position.y, Target), 0.05f);

		horizontal = Input.GetAxis("Horizontal");
		vertical = Input.GetAxis("Vertical");

		rigidbody.AddForce(((transform.right * horizontal) + (transform.forward * vertical)) * speed/Time.deltaTime);
	}
}