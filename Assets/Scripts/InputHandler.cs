using System;
using UnityEngine;

[Serializable]
public class InputHandler {
    [SerializeField] private PlayView playView;
    private int _direction;
    
    public event Action<int> MoveEvent;
    public event Action JumpEvent;

    public void Initialize() {
        playView.Initialize();
        Subscription();
    }

    public void OnUpdate() { MoveEvent?.Invoke(_direction); } 
    private void OnLeft(bool value) {
        _direction = 0;
        if (value == true) _direction = -1;
    }

    private void OnRight(bool value) {
        _direction = 0;
        if (value == true) _direction = 1;
    }

    private void OnJump(bool value) { if (value == true) JumpEvent?.Invoke(); }
    
    public void Subscription() {
        playView.LeftEvent += OnLeft;
        playView.RightEvent += OnRight;
        playView.JumpEvent += OnJump;
    }
    
    public void UnSubscription() {
        playView.LeftEvent -= OnLeft;
        playView.RightEvent -= OnRight;
        playView.JumpEvent -= OnJump;
    }
    
}