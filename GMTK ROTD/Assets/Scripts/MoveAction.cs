using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAction : MonoBehaviour
{

    Animator animator;

    private Vector3 targetPosition;

    float stoppingDistance = .1f;
    private int runHash;

    private Unit unit;

    [SerializeField] private int maxMoveDistance = 4;

    private void Awake()
    {
        unit = GetComponent<Unit>();
        targetPosition = transform.position;

        runHash = Animator.StringToHash("isWalking");
        animator = GetComponent<Animator>();
    }

    private void Update()
    {

        if (Vector3.Distance(transform.position, targetPosition) > stoppingDistance)
        {
            animator.SetBool(runHash, true);
            Vector3 moveDirection = (targetPosition - transform.position).normalized;
            float MoveSpeed = 4f;
            transform.position += moveDirection * MoveSpeed * Time.deltaTime;

            float rotateSpeed = 10f;

            transform.forward = Vector3.Lerp(transform.forward, moveDirection, rotateSpeed * Time.deltaTime);
        }
        else
        {
            animator.SetBool(runHash, false);

        }
    }
    public void Move(GridPosition gridPosition)
    {
        this.targetPosition = levelGrid.Instance.GetWorldPosition(gridPosition);
    }

    public bool IsValidActionGridPosition(GridPosition gridPosition)
    {
        List<GridPosition> validGridPositionList = GetValidActionGridPositonList();
        return validGridPositionList.Contains(gridPosition);
    }

    public List<GridPosition> GetValidActionGridPositonList()
    {
        List<GridPosition> validGridPositionList = new List<GridPosition>();

        GridPosition unitGridPosition = unit.GetGridPosition();

        for (int x = -maxMoveDistance; x <= maxMoveDistance; x++)
        {
            for(int z = -maxMoveDistance; z <= maxMoveDistance; z++)
            {
                GridPosition offsetGridPosition = new GridPosition(x, z);
                GridPosition testGridPosition= unitGridPosition + offsetGridPosition;

                if (!levelGrid.Instance.IsValidGridPosition(testGridPosition))
                {
                    continue;
                }
                
                if (unitGridPosition == testGridPosition)
                {
                    continue;
                }
                if (levelGrid.Instance.HasAnUnitOnGridPosition(testGridPosition))
                {
                    continue;
                }

                validGridPositionList.Add(testGridPosition);
            }
        }

        return validGridPositionList;
    }
}
