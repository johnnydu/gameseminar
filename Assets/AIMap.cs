using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AIMap : MonoBehaviour {
	// Use this for initialization

	private ArrayList vertices;
	private ArrayList edges;
	private Dictionary<GameObject, ArrayList> map;
	public static int[][] walkable;


	public static Dictionary<GameObject, int[]> nodePosition;

	void Start () {


		nodePosition = new Dictionary<GameObject, int[]>();
		vertices = new ArrayList();
		edges = new ArrayList();
		map = new Dictionary<GameObject, ArrayList>();

		walkable = new int[][] { new int[] {1, 1, 1, 1, 1, 1, 1, 0, 0, 1, 1, 1, 1, 1, 1, 1}, 
								  new int[] {1, 0, 0, 1, 0, 0, 1, 0, 0, 1, 0, 0, 1, 0, 0, 1},
								  new int[] {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
								  new int[] {1, 0, 0, 0, 1, 0, 1, 0, 0, 0, 1, 0, 1, 0, 0, 1},
								  new int[] {1, 1, 1, 1, 1, 0, 1, 1, 0, 1, 1, 0, 1, 1, 1, 1},
								  new int[] {0, 0, 0, 0, 1, 0, 0, 1, 0, 1, 0, 0, 1, 0, 0, 0},
								  new int[] {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
								  new int[] {1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 1, 1},
								  new int[] {0, 0, 0, 0, 1, 0, 1, 1, 1, 1, 1, 0, 1, 0, 0, 0},
								  new int[] {1, 1, 1, 1, 1, 0, 1, 0, 0, 0, 1, 0, 1, 1, 1, 1},
								  new int[] {1, 0, 0, 0, 1, 0, 1, 1, 0, 1, 1, 0, 0, 0, 0, 1},
								  new int[] {1, 1, 1, 0, 1, 0, 0, 1, 0, 1, 0, 0, 1, 1, 1, 1},
								  new int[] {0, 0, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0},
								  new int[] {1, 1, 1, 1, 1, 0, 1, 0, 0, 1, 0, 0, 1, 1, 1, 1},
								  new int[] {1, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 1},
								  new int[] {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1} };


		for (int i = 0; i < transform.childCount; i++) {
			Transform child = transform.GetChild(i).gameObject.transform;
			for (int j = 0; j < child.childCount; j++) {

				child.GetChild(j).gameObject.tag = "node";
				nodePosition.Add(child.GetChild(j).gameObject, new int[] {i, j});
				//walkable.Add(child.GetChild(j), );


				child.GetChild(j).gameObject.GetComponent<Renderer>().enabled = false;

				//add each node to vertice list
				//vertices.Add(child.GetChild(j));

				//make edges and map
				/**
				ArrayList temp = new ArrayList();
				if (j-1 >= 0) {
					edges.Add(new Transform[] {child.GetChild(j), child.GetChild(j-1)});
					temp.Add(child.GetChild(j-1));
				}

				if (i-1 >= 0) {
					edges.Add(new Transform[] {child.GetChild(j),
						transform.GetChild(i-1).gameObject.transform.GetChild(j)});
					temp.Add(transform.GetChild(i-1).gameObject.transform.GetChild(j));
				}

				if (j+1 < child.childCount) {
					edges.Add(new Transform[] {child.GetChild(j),
						child.GetChild(j+1)});
						temp.Add(child.GetChild(j+1));
				}

				if (i+1 < transform.childCount) {
					edges.Add(new Transform[] {child.GetChild(j),
						transform.GetChild(i+1).gameObject.transform.GetChild(j)});
					temp.Add(transform.GetChild(i+1).gameObject.transform.GetChild(j));
				}

				map.Add(child.GetChild(j).gameObject, temp);
				*/
			}
		}

		/**
		for (int i = 0; i < transform.childCount; i++) {
			Transform child = transform.GetChild(i).gameObject;
			for (int j = 0; j < child.childCount; j++) {
				child.GetChild(j).gameObject;
				ArrayList connection = new ArrayList;
				child.GetChild(j).gameObject;
			}
		}
		*/


	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void OnTriggerEnter(Collider collision) {
		if(collision.gameObject.CompareTag("wall")) {
			Debug.Log("i hit a wall");
		}
	}


}
