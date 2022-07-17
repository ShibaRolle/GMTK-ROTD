using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{

    [SerializeField] private Unit unit;

    [SerializeField] InputReader input;
    private void Start()
    {
        input.RightClickEvent += rightclick;
    }

    private void rightclick()
    {
        unit.GetMoveAction().GetValidActionGridPositonList();
    }

    private void Update()
    {

    }
}
