using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadManager : MonoBehaviour {

    public int Level;
    public GameObject[] prefabs;

    private Transform playerTransform;
    private float spawnZ = -5f; // -4.86f;        // 타일 스폰 위치
    private float tileLength = 5f; // 4.86f;   // 한 타일의 길이
    private float safeZone = 50f;
    private int amnTilesOnScreen = 42;  // 한번에 소환할 타일의 갯수
    private int lastPrefabIndex = 0;

    private List<GameObject> activeTiles;

	// Use this for initialization
	private void Start () {
		
        activeTiles = new List<GameObject>();
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;

        // 한번에 생성하는 것으로 변경
        for (int i = 0; i < amnTilesOnScreen; i++) {
            if (i < 6)
                SpawnTile(0);
            else
                SpawnTile();
        }
    }
	
	// Update is called once per frame
	private void Update () {
        if (playerTransform.position.z - safeZone > (spawnZ - amnTilesOnScreen * tileLength))
        {
            DeleteTile();
        }
	}

    private void SpawnTile(int prefabIndex = -1) {
        GameObject go;

        if (prefabIndex == -1)
            go = Instantiate(prefabs[RandomPrefabIndex()]) as GameObject;
        else
            go = Instantiate(prefabs[prefabIndex]) as GameObject;

        go.transform.SetParent(transform);
        go.transform.position = Vector3.forward * spawnZ;
        spawnZ += tileLength;

        activeTiles.Add(go);
    }

    private void DeleteTile() {
        Destroy(activeTiles[0]);
        activeTiles.RemoveAt(0);
    }

    private int RandomPrefabIndex() {
        if (prefabs.Length <= 1)
            return 0;

        int randomIndex = lastPrefabIndex;

        // 랜덤 프리팹 설정
        while (randomIndex == lastPrefabIndex) {
            randomIndex = Random.Range(0, prefabs.Length);
        }

        lastPrefabIndex = randomIndex;

        return randomIndex;
    }
}
