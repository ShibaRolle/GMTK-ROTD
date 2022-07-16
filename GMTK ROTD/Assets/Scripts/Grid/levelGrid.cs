using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelGrid : MonoBehaviour
{
    [SerializeField] private Transform gridDebuggObjectPrefab;

    public static levelGrid Instance { get; private set; }

    private GridSystem gridSystem;

    private void Awake()
    {
        gridSystem = new GridSystem(10, 10, 2);
        gridSystem.CreateDebugObject(gridDebuggObjectPrefab);

        if (Instance != null)
        {
            Debug.LogError("There's more than on UnitActionSystem! " + transform + "-" + Instance);
            Destroy(gameObject);

            return;
        }

        Instance = this;
    }

    public void AddUnitAtGridPosition(GridPosition gridPosition, Unit unit)
    {
       GridObject gridObject =  gridSystem.GetGridObject(gridPosition);
       gridObject.AddUnit(unit);
    }
    public List<Unit> GetUnitListAtGridPosition(GridPosition gridPosition)
    {
       GridObject gridObject = gridSystem.GetGridObject(gridPosition);
       return gridObject.GetUnitList();
    }

    public void RemoveUnitAtGridPosition(GridPosition gridPosition, Unit unit)
    {
        GridObject gridObject = gridSystem.GetGridObject(gridPosition);
        gridObject.RemoveUnit(unit);
    }

    public void UnitMovedGridPosition(Unit unit, GridPosition fromGridPosition, GridPosition toGridPosition)
    {
        RemoveUnitAtGridPosition(fromGridPosition, unit);
        AddUnitAtGridPosition(toGridPosition, unit);
    }
    public GridPosition GetGridPosition(Vector3 worldPosition) => gridSystem.GetGridPosition(worldPosition);
}
