using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridSystemVisual : MonoBehaviour
{
    [SerializeField] private Transform gridSystemVisualPrefab;

    private void Start()
    {
        for (int x = 0; x < levelGrid.Instance.GetWidth(); x++)
        {
            for (int z = 0; z < levelGrid.Instance.GetHeight(); z++)
            {
                GridPosition gridPosition = new GridPosition(x,z);
                Instantiate(gridSystemVisualPrefab, levelGrid.Instance.GetWorldPosition(gridPosition),Quaternion.identity);
            }
        }
    }
}
