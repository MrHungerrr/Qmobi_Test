using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vkimow.Unity.Tools.Single;
using TMPro;
using Game.Main;
using Game.Objects.Ship;

public class UIManager : MonoSingleton<UIManager>
{

    [SerializeField] private TextMeshProUGUI _scoreField;
    [SerializeField] private TextMeshProUGUI _lifeCountField;
    [SerializeField] private TextMeshProUGUI _highScoreField;
    [SerializeField] private TextMeshProUGUI _mainTitleField;
    [SerializeField] private TextMeshProUGUI _exitHintField;
    [SerializeField] private TextMeshProUGUI _resumeHintField;


    public void Setup()
    {
        GameManager.Instance.OnGameStateChanged += ChangeUIType;
        ScoreManager.Instance.OnScoreChanged += Score;
        ScoreManager.Instance.OnHighScoreChanged += HighScore;
        ShipController.Instance.LifeController.OnLifeCountChanged += LifeCount;

        Score(ScoreManager.Instance.Score);
        HighScore(ScoreManager.Instance.HighScore);
    }

    private void ChangeUIType(GameManager.GameState type)
    {
        switch (type)
        {
            case GameManager.GameState.Game:
                {
                    _mainTitleField.enabled = false;
                    _exitHintField.enabled = false;
                    _resumeHintField.enabled = false;
                    break;
                }
            case GameManager.GameState.Pause:
                {
                    _mainTitleField.enabled = true;
                    _exitHintField.enabled = true;
                    _resumeHintField.enabled = true;
                    MainTitle("PAUSE");
                    break;
                }
            case GameManager.GameState.GameOver:
                {
                    _mainTitleField.enabled = true;
                    _exitHintField.enabled = true;
                    _resumeHintField.enabled = true;
                    MainTitle("GAME OVER");
                    break;
                }
        }
    }

    public void Score(int value)
    {
        _scoreField.text = value.ToString();
    }

    public void HighScore(int value)
    {
        _highScoreField.text = $"High Score: {value}";
    }

    public void LifeCount(int value)
    {
        _lifeCountField.text = $"Life Count: {value}";
    }

    public void MainTitle(string text)
    {
        _mainTitleField.text = text;
    }

}
