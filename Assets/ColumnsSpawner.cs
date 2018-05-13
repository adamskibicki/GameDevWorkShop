//https://pastebin.com/fvn8DfKt

using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ColumnsSpawner : MonoBehaviour
{
    public GameObject Columns;

    private List<GameObject> ColumnsPool = new List<GameObject>();

    private List<GameObject> ActiveColumns = new List<GameObject>();

    private void Awake()
    {
        InvokeRepeating("SpawnColumn", 2f, 2f);
        InvokeRepeating("CheckColumnsOutOfScreen", 2f, 2f);
    }

    private void SpawnColumn()
    {
        if (ColumnsPool.Count > 0)
        {
            var columns = ColumnsPool.Last();

            ColumnsPool.Remove(columns);

            ActiveColumns.Add(columns);

            columns.SetActive(true);

            columns.transform.position = new Vector3(15, Random.Range(-3f, 3f), 0);
        }
        else
        {
            ActiveColumns.Add(Instantiate(Columns, new Vector3(15, Random.Range(-3f, 3f), 0), Quaternion.identity));
        }
    }

    private void CheckColumnsOutOfScreen()
    {
        for (int i = 0; i < ActiveColumns.Count; i++)
        {
            if (ActiveColumns[i].transform.position.x < -15)
            {
                var columns = ActiveColumns[i];
                ActiveColumns.Remove(ActiveColumns[i]);
                i--;

                columns.SetActive(false);

                ColumnsPool.Add(columns);
            }
        }
    }
}
