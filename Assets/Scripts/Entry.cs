using UnityEngine;

public class Entry : MonoBehaviour {
    [SerializeField] private CameraHandler cameraHandler;
    [SerializeField] private InputHandler inputHandler;
    [SerializeField] private Player player;

    private void Awake() { Initialize(); }

    private void Initialize() {
        inputHandler.Initialize();
        Subscription();
    }

    private void Update() { inputHandler.OnUpdate(); }
    private void LateUpdate() { cameraHandler.LateUpdate(); }
    private void OnMove(int value) { player.Move(value); }
    private void OnJump() { player.Jump(); }

    private void Subscription() {
        inputHandler.MoveEvent += OnMove;
        inputHandler.JumpEvent += OnJump;
    }

    private void UnSubscription() {
        inputHandler.MoveEvent -= OnMove;
        inputHandler.JumpEvent -= OnJump;
    }
    
    
    private void OnDestroy() {
        inputHandler.UnSubscription();
        UnSubscription();
    }
}