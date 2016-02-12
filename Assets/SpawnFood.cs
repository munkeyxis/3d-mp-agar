using UnityEngine;
using UnityEngine.Networking;

public class SpawnFood : MonoBehaviour {
	public GameObject FoodPrefab;
	public int StartingFoodCount;
	public int MaxFoodCount;
	public float SpawnTimeDelay;
	float _spawnTimer;

	// Use this for initialization
	void Start () {
		_spawnTimer = 0;
		for(int i = 0; i < StartingFoodCount; i++) {
			SpawnFoodPrefab();
		}
	}
	
	// Update is called once per frame
	void Update () {
		_spawnTimer += 1 * Time.deltaTime;
		GameObject[] foods = GameObject.FindGameObjectsWithTag("Food");

		if(foods.Length <= MaxFoodCount && _spawnTimer >= SpawnTimeDelay) {
			SpawnFoodPrefab();
			_spawnTimer = 0;
		}
	}

	void SpawnFoodPrefab() {
		GameObject food = Instantiate(FoodPrefab);
		Vector3 randomLocation = new Vector3(Random.Range(-28, 28), 0.5f, Random.Range(-28, 28));
		food.transform.localPosition = randomLocation;
		NetworkServer.Spawn(food);
	}
}
