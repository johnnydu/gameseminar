using UnityEngine;
using System.Collections;

public class createObject : MonoBehaviour {

	public Transform pillar;
	public Transform torch;
	public Transform enemy;
	public Transform rock1;
	public Transform rock2;
	public Transform rock3;
	public Transform rock4;
	public Transform rock5;
	public int rockNumber=0;

	static int currentScore =0;


	// Use this for initialization
	void Start () {
		// for (int z = -40; z < 40; z++) {
		// 	for (int x = -40; x < 40; x++) {
		// 		if(z%15 == 0 && x%15 == 0){
		// 			Instantiate(pillar, new Vector3(x, 10, z), Quaternion.identity);
		// 		}
		// 	}
		// }

		// //松明を動的に生成
		// for (int z = -40; z < 40; z++) {
		// 	for (int x = -40; x < 40; x++) {
		// 		if(z%8 == 0 && x%8 == 0){
		// 			Instantiate(torch, new Vector3(x,5, z), Quaternion.identity);
		// 			Instantiate(torch, new Vector3(x, 15, z), Quaternion.identity);
		// 		}
		// 	}
		// }


		// //地面(地下ダンジョンの屋根)を動的に生成
		// for (int z = -60; z < 60; z=z+4) {
		// 	for (int x = -60; x < 60; x=x+4) {
		// 		rockNumber = UnityEngine.Random.Range(0,4);
		// 		if(rockNumber == 0){
		// 			Instantiate(rock1, new Vector3(x,5,z),Quaternion.identity);
		// 		}else if(rockNumber == 1){
		// 			Instantiate(rock2, new Vector3(x,5,z),Quaternion.identity);
		// 		}else if(rockNumber == 2){
		// 			Instantiate(rock3, new Vector3(x,5,z),Quaternion.identity);
		// 		}else if (rockNumber == 3){
		// 			Instantiate(rock4, new Vector3(x,5,z),Quaternion.identity);
		// 		}else {
		// 			Instantiate(rock5, new Vector3(x,5,z),Quaternion.identity);
		// 		}
		// 	}
		// }		

		// //敵をランダムな位置に生成
		// Instantiate(enemy, new Vector3(UnityEngine.Random.Range(0,40),0,UnityEngine.Random.Range(0,40)),Quaternion.identity);


	}
	
	// Update is called once per frame
	void Update () {

	}

}
