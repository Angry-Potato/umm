using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class PenguinController : MonoBehaviour {

	private Rigidbody2D myRigidBody;
	private Animator myAnim;
	public float penguinJumpForce = 500f;

	// Use this for initialization
	void Start () {
		myRigidBody = GetComponent<Rigidbody2D>();
		myAnim = GetComponent<Animator>();
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetButtonUp("Jump") || Input.GetButtonUp("Fire1")) {
			myRigidBody.AddForce(transform.up*penguinJumpForce);
		}
		myAnim.SetFloat("vVelocity", Mathf.Abs(myRigidBody.velocity.y));
	}

	void OnDestroy() {
		SceneManager.LoadScene("dead");
	}
}
