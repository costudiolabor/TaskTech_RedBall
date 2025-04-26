using UnityEngine;

public class Player : MonoBehaviour {
    [SerializeField] private Rigidbody2D rigidBody2D;
    [SerializeField] private float speed = 10f;
    [SerializeField] private float jumpForce = 300f;
    private bool _isGround;

    public void Move(float moveHorizontal) {
        Vector2 movement = new Vector2(moveHorizontal, 0.0f);
        rigidBody2D.AddForce(movement * speed * Time.deltaTime);
    }
    public void Jump() { if (_isGround) { rigidBody2D.AddForce(Vector2.up * jumpForce); } }
    private void OnCollisionStay2D(Collision2D other) { CheckGround(other, true); }
    private void OnCollisionExit2D(Collision2D other) { CheckGround(other, false);}
    private void CheckGround(Collision2D other, bool value) { 
        if (other.gameObject.CompareTag("Ground")) { _isGround = value; }
    }
}
