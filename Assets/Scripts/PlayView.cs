using System;
using UnityEngine;

public class PlayView : MonoBehaviour {
    [SerializeField] private ButtonCustom buttonLeft;
    [SerializeField] private ButtonCustom buttonRight;
    [SerializeField] private ButtonCustom buttonJump;

    public event Action<bool> LeftEvent, RightEvent, JumpEvent;
    public void Initialize() {
        buttonLeft.ButtonClick += OnLeftClick;
        buttonRight.ButtonClick += OnRightClick;
        buttonJump.ButtonClick += OnJumpClick;
    }

    private void OnLeftClick(bool value) { LeftEvent?.Invoke(value); }
    private void OnRightClick(bool value) { RightEvent?.Invoke(value); }
    private void OnJumpClick(bool value) { JumpEvent?.Invoke(value); }

    private void OnDestroy() {
        buttonLeft.ButtonClick -= OnLeftClick;
        buttonRight.ButtonClick -= OnRightClick;
        buttonJump.ButtonClick -= OnJumpClick;
    }
}
