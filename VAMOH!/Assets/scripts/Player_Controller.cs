using UnityEngine;
using System.Collections;

public class Player_Controller : MonoBehaviour {

    //Movement variables
    public float maxspeed;
	//private bool allow = false;
	public GameObject CajaScreen;

    Rigidbody2D myRB;
    Animator myAnim;
    bool facingRight;

	// Use this for initialization
	void Start () {
        myRB = GetComponent<Rigidbody2D>();
        myAnim = GetComponent<Animator>();
        facingRight = true;
	}
	
	// Update is called once per frame
	void Update () {
        float move = Input.GetAxis("Horizontal");
        myAnim.SetFloat("Speed", Mathf.Abs(move));

        myRB.velocity = new Vector2(move * maxspeed, myRB.velocity.y);

        if (move > 0 && !facingRight){
            flip();
        }   else if (move < 0 && facingRight){
            flip();
        }
	}

    void flip(){
        facingRight = !facingRight;
        Vector3 TheScale = transform.localScale;
        TheScale.x *= -1;
        transform.localScale = TheScale;
    }

	void OnTriggerStay2D(Collider2D other){
		if (other.gameObject.tag  == "switch") {
			CajaScreen.SetActive (true);
		}
	}
}
 