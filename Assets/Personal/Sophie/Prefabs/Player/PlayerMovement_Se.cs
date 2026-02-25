using UnityEngine;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class PlayerMovement_Se : MonoBehaviour
{
    float Horizontal;
    float Vertical;
    public float speed = 8f;
    float JumpingPower = 16f;
    bool isFacingRight = true;

    bool IsWallSliding;
    float WallSlideSpeed = 2f;

    bool IsWallJumping;
    float WallJumpDirection;
    float WallJumpTime = 0.2f;
    float WallJumpCounter;
    float WallJumpDuration = 0.4f;
    Vector2 WallJumpPower = new Vector2(8f, 16f);

    public AudioClip JumpClip;
    public AudioSource JumpSource;
    public GameObject QuitMenu;

    [SerializeField] private Animator _animator;    // calling apon the animator
    private bool Walking;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private Transform WallCheck;
    [SerializeField] private LayerMask WallLayer;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Horizontal = Input.GetAxisRaw("Horizontal");
        Vertical = Input.GetAxisRaw("Vertical");



        if (Input.GetButtonDown("Jump") && IsGrounded() == true)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, JumpingPower);
            JumpSource.PlayOneShot(JumpClip);

            _animator.SetBool("Is_Jumping", !IsGrounded()); // animation for if character is jumping

        }

        if (Input.GetButtonUp("Jump") && rb.linearVelocity.y > 0f)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, rb.linearVelocity.y * 0.5f);


        }

        WallSlide();
        WallJump();

        if (!IsWallJumping)
        {
            Flip();
        }



    }

    private void FixedUpdate()
    {

        _animator.SetFloat("Input_x", Mathf.Abs(rb.linearVelocity.x));
        _animator.SetFloat("Input_y", rb.linearVelocity.y);

        if (!IsWallJumping)
        {
            rb.linearVelocity = new Vector2(Horizontal * speed, rb.linearVelocity.y);
        }


    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapBox(groundCheck.position, groundCheck.GetComponent<BoxCollider2D>().size * transform.localScale, 0, groundLayer);
    }

    private bool TouchingWall()
    {
        return Physics2D.OverlapBox(WallCheck.position, WallCheck.GetComponent<BoxCollider2D>().size * transform.localScale, 0, WallLayer);
    }

    private void WallSlide()
    {
        if (TouchingWall() && !IsGrounded() && Horizontal != 0f)
        {
            IsWallSliding = true;
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, Mathf.Clamp(rb.linearVelocity.y, -WallSlideSpeed, float.MaxValue));
        }

        else
        {
            IsWallSliding = false;
        }
    }

    private void WallJump()
    {
        if (IsWallSliding)
        {
            IsWallJumping = false;
            WallJumpDirection = -transform.localScale.x;
            WallJumpCounter = WallJumpTime;

            CancelInvoke(nameof(StopWallJumping));
        }

        else
        {
            WallJumpCounter -= Time.deltaTime;
        }

        if (Input.GetButtonDown("Jump") && WallJumpCounter > 0f)
        {
            IsWallJumping = true;
            rb.linearVelocity = new Vector2(WallJumpDirection * WallJumpPower.x, WallJumpPower.y);
            WallJumpCounter = 0f;

            if (transform.localScale.x != WallJumpDirection)
            {
                isFacingRight = !isFacingRight;
                Vector3 localScale = transform.localScale;
                localScale.x *= -1f;
                transform.localScale = localScale;
            }

            Invoke(nameof(StopWallJumping), WallJumpDuration);



        }
    }

    private void StopWallJumping()
    {
        IsWallJumping = false;
    }

    // Add flip when adding sprite
    private void Flip()
    {


        if (isFacingRight && Horizontal < 0f || !isFacingRight && Horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;


        }
    }

    private void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
        _animator.SetBool("Is_Jumping", !IsGrounded()); // animation for if character is jumping
    }
}
