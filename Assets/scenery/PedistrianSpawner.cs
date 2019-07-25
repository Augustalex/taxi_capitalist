﻿using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace scenery
{
    public class PedistrianSpawner : MonoBehaviour
    {
        public GameObject[] Pedestrians;
        private IEnumerable<Transform> _spawns;

        public void Awake()
        {
            _spawns = GameObject
                .FindGameObjectsWithTag("PedestrianSpawn")
                .Select(spawn => spawn.transform);

            foreach (var spawn in _spawns)
            {
                StartCoroutine(SpawnPedestriansAtPoint(spawn));
            }
        }


        private IEnumerator SpawnPedestriansAtPoint(Transform spawn)
        {
            yield return new WaitForSeconds(Random.Range(10, 30));

            while (true)
            {
                var randomPrefab = Pedestrians[Random.Range(0, Pedestrians.Length)];
                var pedestrian = Instantiate(randomPrefab, spawn.position, spawn.rotation);
                Destroy(pedestrian, 20);

                yield return new WaitForSeconds(Random.Range(10, 30));
            }
        }
    }
}