using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unity.FPS.AI
{
    public class DropManager : MonoBehaviour
    {
        public GameObject[] enemies_room1;

        public GameObject[] enemies_room2;
        public GameObject rpgEnemy;

        public GameObject[] dropPrefabs_room1;

        public GameObject[] dropPrefabs_room2;
        public GameObject rpg_prefab;

        // Start is called before the first frame update
        void Start()
        {
            enemies_room1 = GameObject.FindGameObjectsWithTag("Enemy_Floor1");
            enemies_room2 = GameObject.FindGameObjectsWithTag("Enemy_Room2");
            rpgEnemy = GameObject.FindGameObjectsWithTag("RPG")[0];
            for (int i = 0; i < enemies_room1.Length; i++)
            {
                try
                {
                    enemies_room1[i].GetComponent<EnemyController>().SetLootPrefab(dropPrefabs_room1[i]);
                }
                catch (System.Exception)
                {
                    enemies_room1[i].GetComponent<EnemyController>().SetLootPrefab(dropPrefabs_room1[0]);
                }
            }
            for (int i = 0; i < enemies_room2.Length; i++)
            {
                try
                {
                    enemies_room2[i].GetComponent<EnemyController>().SetLootPrefab(dropPrefabs_room2[i]);
                }
                catch (System.Exception)
                {
                    enemies_room2[i].GetComponent<EnemyController>().SetLootPrefab(dropPrefabs_room2[0]);
                }
            }
            rpgEnemy.GetComponent<EnemyController>().SetLootPrefab(rpg_prefab);
            rpgEnemy.transform.position = rpgEnemy.transform.position + new Vector3(0f, 10f, 0f);
            Debug.Log("movido");
        }
    }
}
