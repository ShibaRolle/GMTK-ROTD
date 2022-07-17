using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Unit : MonoBehaviour
{
    private MoveAction moveAction;

    private GridPosition gridPosition;

    private void Awake()
    {
        moveAction = GetComponent<MoveAction>();
    }

    private void Start()
    {
        gridPosition = levelGrid.Instance.GetGridPosition(transform.position);
        levelGrid.Instance.AddUnitAtGridPosition(gridPosition, this);
    }

    private void Update()
    {

        GridPosition newGridPosition = levelGrid.Instance.GetGridPosition(transform.position);

        if (newGridPosition != gridPosition)
        {
            levelGrid.Instance.UnitMovedGridPosition(this, gridPosition, newGridPosition);
            gridPosition = newGridPosition;
        }

    }

    public MoveAction GetMoveAction()
    {
        return moveAction;
    }

    public GridPosition GetGridPosition()
    {
        return gridPosition;
    }
}
