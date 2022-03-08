using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unity.FPS.AI
{
    public class DropManager : MonoBehaviour
    {
        public GameObject[] enemies;

        public GameObject[] dropPrefabs;
        // Start is called before the first frame update
        void Start()
        {
            enemies = GameObject.FindGameObjectsWithTag("Enemy_Floor1");
            for (int i = 0; i < enemies.Length; i++)
            {
                try
                {
                    enemies[i].GetComponent<EnemyController>().SetLootPrefab(dropPrefabs[i]);
                }
                catch (System.Exception)
                {
                    enemies[i].GetComponent<EnemyController>().SetLootPrefab(dropPrefabs[0]);
                }

            }
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
