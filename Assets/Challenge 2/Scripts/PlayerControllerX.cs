using UnityEngine;

namespace Challenge_2.Scripts
{
    public class PlayerControllerX : MonoBehaviour
    {
        public GameObject dogPrefab;

        private const float SendDelay = 1f;
        private float _timer;

        private void Update()
        {
            _timer += Time.deltaTime;

            if (!(_timer >= SendDelay)) return;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                _timer = 0;
            }
        }
    }
}