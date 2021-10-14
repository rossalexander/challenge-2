using UnityEngine;

namespace Challenge_2.Scripts
{
    public class SpawnManagerX : MonoBehaviour
    {
        public GameObject[] ballPrefabs;

        private float spawnLimitXLeft = -22;
        private float spawnLimitXRight = 7;
        private float spawnPosY = 30;

        private float startDelay = 1.0f;
        // public float spawnInterval = 4.0f;

        // Start is called before the first frame update
        private void Start()
        {
            Invoke("SpawnRandomBall", startDelay);
        }

        // Spawn random ball at random x position at top of play area
        private void SpawnRandomBall()
        {
            // Generate random ball index and random spawn position
            var spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

            var spawnIndex = Random.Range(0, ballPrefabs.Length);

            // instantiate ball at random spawn location
            Instantiate(ballPrefabs[spawnIndex], spawnPos, ballPrefabs[spawnIndex].transform.rotation);

            var spawnInterval = Random.Range(1, 8);
            Invoke("SpawnRandomBall", spawnInterval);
        }
    }
}