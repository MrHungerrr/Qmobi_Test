using Assets.Scripts.Game.Objects.Asteroids;
using Game.Objects.Ship;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vkimow.Tools.Single;


namespace Game.Main
{
    public class GameManager : Singleton<GameManager>
    {
        public enum GameState
        {
            Game,
            Pause,
            GameOver,
            None
        }

        public event Action<GameState> OnGameStateChanged;

        private GameState _gameState = GameState.None;

        public void Setup()
        {
            InputManager.Instance.GamePause += Pause;
            InputManager.Instance.GameRestart += Restart;

            InputManager.Instance.PauseResume += Resume;
            InputManager.Instance.PauseExit += Exit;

            InputManager.Instance.GameOverRestart += Restart;
            InputManager.Instance.GameOverExit += Exit;

            ShipController.Instance.OnShipExploded += GameOver;

            Reset();
        }

        private void Reset()
        {
            ScoreManager.Instance.Reset();
            ChangeGameState(GameState.Game);
            ShipController.Instance.Reset();
        }

        private void ChangeGameState(GameState state)
        {
            if (_gameState == state)
                return;

            _gameState = state;
            OnGameStateChanged?.Invoke(state);
        }

        private void Pause()
        {
            Time.timeScale = 0f;
            ChangeGameState(GameState.Pause);
        }

        private void Resume()
        {
            Time.timeScale = 1f;
            ChangeGameState(GameState.Game);
        }

        private void GameOver()
        {
            ChangeGameState(GameState.GameOver);
        }

        private void Restart()
        {
            SceneManager.LoadScene(1);
            Reset();
        }

        private void Exit()
        {
            Application.Quit();
        }
    }
}