using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class bomb : MonoBehaviour
{
	//a holder for our Animator
	Animator anim;
	//a public float for the explosion radius
	public float explodeRadius = 2f;

	// Use this for initialization
	void Start()
	{
		anim = GetComponent<Animator>();
	}

	// Update is called once per frame
	void Update()
	{
		//if we are done exploding
		if (anim.GetCurrentAnimatorStateInfo(0).IsName("bombdead"))
		{
			//destroy all the objects in a radius unless they are tagged Player or hand
			Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, explodeRadius);
			foreach (Collider2D col in colliders)
			{
				if (col.tag == "Player")
				{
					//Application.LoadLevel(1);
					SceneManager.LoadScene(1);
					Destroy(col.GetComponent<Collider2D>().gameObject);
					//Debug.Break();
					//return;
					//Destroy(other.gameObject.transform.parent.gameObject);
					//Destroy(other.gameObject);

					//GetComponent<Collider2D>()
					//Destroy(col.collider2D.gameObject);
				}
			}
			Destroy(this.gameObject);

		}
	}
}