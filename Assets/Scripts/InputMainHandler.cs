using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputMainHandler : MonoBehaviour
{
    ControlSchematic inputActions;
    
    public float MoveRangeOnX {  get; private set; }   
    public float MoveMouseOnX { get; private set; }
    
    
    
    
    public static InputMainHandler Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            inputActions = new ControlSchematic();
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else { Destroy(gameObject); }
        EnableInputs();
    }

    void EnableInputs()
    {
        inputActions.Game.MovePlatform.performed += context => MoveRangeOnX = context.ReadValue<float>();
        inputActions.Game.MovePlatform.canceled  += context => MoveRangeOnX = 0.0f;

        inputActions.Game.Mouse_Pos.performed += context => MoveMouseOnX = context.ReadValue<float>();
        inputActions.Game.Mouse_Pos.canceled  += context => MoveMouseOnX = 0.0f;
    }


    private void OnEnable()
    {
        inputActions.Game.MovePlatform.Enable();
        inputActions.Game.Mouse_Pos.Enable();
    }
    private void OnDisable()
    {
        inputActions.Game.MovePlatform.Disable();
        inputActions.Game.Mouse_Pos.Disable();
    }
}
