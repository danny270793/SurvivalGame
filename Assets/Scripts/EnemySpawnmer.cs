using UnityEngine;

public class EnemySpawnmer : MonoBehaviour
{
    public int level = 1;
    public int spawnedEnemies = 0;
    public float spawnInterval = 1f;
    private float timer;

    void SpawnEnemy()
    {
        int x = Random.Range(-3, 3);
        int y = 1;
        int z = 60;
        if(x == 0)
        {
            if(Random.Range(-3, 3) > 0)
            {
                x += 1;
            }
            else
            {
                x -= 1;
            }
            
        }
        Vector3 spawnPosition = new Vector3(x, y, z);
            
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.position = spawnPosition;
        // cube.transform.localScale = new Vector3(0.25f, 0.25f, 0.25f);
        cube.AddComponent<EnemyMovementController>();
        cube.AddComponent<Rigidbody>();
        //Rigidbody rb = cube.AddComponent<Rigidbody>();
        //rb.mass = 200f;
        cube.name = Constants.ENEMY;

        spawnedEnemies += 1;
        if(spawnedEnemies > 5)
        {
            level += 1;
            spawnedEnemies = 0;
        }
    }

    void createEnemyOnInterval()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval/level)
        {
            SpawnEnemy();
            timer = 0f;
        }
    }

    // main
    void Start()
    {
        
    }

    void Update()
    {
        createEnemyOnInterval();
    }
}
