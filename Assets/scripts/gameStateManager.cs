using System;
using UnityEngine;

public class gameStateManager : MonoBehaviour
{
    public static gameStateManager Instance { get; set; }

    public enum GameState
    {
        MainMenu,
        Silence,
        ThiefProwling,
        ThiefCaught,
        MouseProwling,
        MouseCaught,
        GrandmaProwling,
        GrandmaCaught,
        GameOver

    }

    public GameState CurrentState { get; set; }

    public static event Action<GameState> OnStateChanged;

    private void Start()
    {
        UpdateState(GameState.MainMenu);

    }

    private void UpdateState(GameState newState)
    {
        CurrentState = newState;
        switch (newState)
        {
            case GameState.MainMenu:
                HandleMainMenu();
                break;
            case GameState.Silence:
                HandleSilence();
                break;
            case GameState.ThiefProwling:
                HandleThiefProwling();
                break;
            case GameState.MouseProwling:
                HandleMouseProwling();
                break;
            case GameState.GrandmaProwling:
                HandleGrandmaProwling();
                break;
            case GameState.ThiefCaught:
                HandleThiefCaught();
                break;
            case GameState.MouseCaught:
                HandleMouseCaught();
                break;
            case GameState.GrandmaCaught:
                HandleGrandmaCaught();
                break;
            case GameState.GameOver:
                HandleGameOver();
                break;
        }

        OnStateChanged?.Invoke(newState);
    }

    private void HandleMainMenu()
    {

    }
    private void HandleSilence()
    {
        Cursor.lockState = CursorLockMode.None;
    }
    private void HandleThiefProwling()
    {
        Cursor.lockState = CursorLockMode.None;
    }
    private void HandleMouseProwling()
    {
        Cursor.lockState = CursorLockMode.None;
    }

    private void HandleGrandmaProwling()
    {
        Cursor.lockState = CursorLockMode.None;
    }
    private void HandleThiefCaught()
    {
        Cursor.lockState = CursorLockMode.None;
    }

    private void HandleMouseCaught()
    {
        Cursor.lockState = CursorLockMode.None;
    }

    private void HandleGrandmaCaught()
    {
        Cursor.lockState = CursorLockMode.None;
    }

    private void HandleGameOver()
    {

    }
}
