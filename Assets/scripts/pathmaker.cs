using UnityEngine;
using System.Collections;

public class pathmaker : MonoBehaviour {

	// put this on a small sphere, it will drop a "breadcrumb" trail of floor tiles
	public float moveSpeed = 5f;
	private int counter = 0;
	public Transform floorPreFab;
	public Transform wallPreFab;
	public Transform pathmakerPrefab;









	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (counter<50) //makes up to 50 tiles
		{
			float randomNumber;
			float tileOrWall;
			randomNumber = Random.Range (0.0f, 1.0f);
			tileOrWall = Random.Range (0.0f, 1.0f);



			
			if (randomNumber < 0.25f)
			{
				transform.Rotate (0f, 90f, 0f);
			}
			else if (randomNumber > 0.25f && randomNumber < 0.5f)
			{
				transform.Rotate (0f,-90f, 0f);
			}
			else if  (randomNumber > 0.99f && randomNumber < 1.0f)
			{
				Instantiate (pathmakerPrefab, transform.position, transform.rotation);
			}
			else if (randomNumber > 0.70f && randomNumber < .80f)
			{
				Instantiate (wallPreFab, transform.position, transform.rotation);
			}

			//Instantiate (wallPreFab, transform.position, transform.rotation);
			Instantiate (floorPreFab, transform.position, transform.rotation);

			transform.Translate (0f, 0f, 5f);
			//Increment Counter
			counter++;
		}
		else
		{

			Destroy (this.gameObject);

		}



	}
}
