using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Unit : MonoBehaviour
{

    Animator animator;

    private Vector3 targetPosition;

    float stoppingDistance = .1f;
    private int runHash;

    private GridPosition gridPosition;

    private void Awake()
    {
        targetPosition = transform.position;

        runHash = Animator.StringToHash("isWalking");
        animator = GetComponent<Animator>();
       
    }

    private void Start()
    {
        gridPosition = levelGrid.Instance.GetGridPosition(transform.position);
        levelGrid.Instance.AddUnitAtGridPosition(gridPosition, this);
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

        GridPosition newGridPosition = levelGrid.Instance.GetGridPosition(transform.position);

        if (newGridPosition != gridPosition)
        {
            levelGrid.Instance.UnitMovedGridPosition(this, gridPosition, newGridPosition);
            gridPosition = newGridPosition;
        }

    }

    public void Move(Vector3 targetPosition)
    {
        this.targetPosition = targetPosition;
    }

}
