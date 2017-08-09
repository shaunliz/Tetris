﻿using UnityEngine;

public class Game : MonoBehaviour {
    [SerializeField] private Game_components.Tetromino _tetromino;
    [SerializeField] private Game_components.Level _level;
    [SerializeField] private Game_components.Point _points;
    [SerializeField] private Game_components.PauseGame _pause;

    public Game_components.Tetromino tetromino { get { return _tetromino; } }
    public Game_components.Level level { get { return _level; } }
    public Game_components.Point points { get { return _points; } }
    public Game_components.PauseGame pause { get { return _pause; } }

    void Start() {
        points.setPoints(0);
        level.bar.BarFinished += level.newLevel;
        level.bar.BarFinished += tetromino.newLevel;
        level.bar.BarFinished += points.newLevel;
    }

    public void addPoints() {
        points.addPoints();
        level.rowRemoved();
    }
}