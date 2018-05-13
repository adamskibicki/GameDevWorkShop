using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ColumnsSpawner : MonoBehaviour
{
    public GameObject Columns;

    private readonly List<GameObject> columnsPool = new List<GameObject>();

    private readonly List<GameObject> activeColumns = new List<GameObject>();

    private void Awake()
    {
        InvokeRepeating("SpawnColumn", 2f, 2f);
        InvokeRepeating("CheckColumnsOutOfScreen", 2f, 2f);
    }

    private void SpawnColumn()
    {
        if (columnsPool.Count > 0)
        {
            var columns = columnsPool.Last();

            columnsPool.Remove(columns);

            activeColumns.Add(columns);

            columns.SetActive(true);

            columns.transform.position = new Vector3(15, Random.Range(-3f, 3f), 0);
        }
        else
        {
            activeColumns.Add(Instantiate(Columns, new Vector3(15, Random.Range(-3f, 3f), 0), Quaternion.identity));
        }
    }

    private void CheckColumnsOutOfScreen()
    {
        for (int i = 0; i < activeColumns.Count; i++)
        {
            if (activeColumns[i].transform.position.x < -15)
            {
                var columns = activeColumns[i];
                activeColumns.Remove(activeColumns[i]);
                i--;

                columns.SetActive(false);

                columnsPool.Add(columns);
            }
        }
    }
}
