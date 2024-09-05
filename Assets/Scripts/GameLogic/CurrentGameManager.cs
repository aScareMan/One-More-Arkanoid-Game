using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ControlValues))]
public class CurrentGameManager : MonoBehaviour
{
    ControlValues mainValues;

    private void Awake()
    {
        mainValues = GetComponent<ControlValues>();
    }


}
