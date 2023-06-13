//using UnityEngine;
//
//public class CharacterJump : MonoBehaviour
//{
//    [SerializeField] private float jumpForce = 5f;
//    private Rigidbody rb;
//    private bool isJumping = false;
//
//    private void Awake()
//    {
//        rb = GetComponent<Rigidbody>();
//    }
//
//    private void OnCollisionEnter(Collision collision)
//    {
//        if (collision.gameObject.CompareTag("Cube") && !isJumping)
//        {
//            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
//            isJumping = true;
//        }
//    }
//
//    private void OnCollisionExit(Collision collision)
//    {
//        if (collision.gameObject.CompareTag("Cube"))
//        {
//            isJumping = false;
//        }
//    }
//}