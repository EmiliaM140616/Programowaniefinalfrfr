using NUnit.Framework.Internal.Filters;
using System;
using UnityEngine;
using UnityEngine.InputSystem.LowLevel;

public class GameStateManager : MonoBehaviour
{
    public enum GameState
    {
        Paused,
        Running
    }

    public GameState CurrentState = GameState.Running;
    public Action OnPauseGame;

    void Start()
    {
        SetGameState(CurrentState);
    }

    void Update()
    {
        if (Input.GetButtonDown("Pause"))
        {
            if (CurrentState == GameState.Paused)
            {
                SetGameState(GameState.Running);
            }
            else if (CurrentState == GameState.Running)
            {
                SetGameState(GameState.Paused);
            }
        }
    }

    public void StartGame()
    {
        SetGameState(GameState.Running);
    }

    private void SetGameState(GameState newState)
    {
        if (newState == GameState.Paused)
        {
            Time.timeScale = 0.0f;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            // if (OnPauseGame != null) - to samo co "?"
            OnPauseGame?.Invoke();
        }
        else if (newState == GameState.Running)
        {
            Time.timeScale = 1.0f;
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
        CurrentState = newState;
    }
}
