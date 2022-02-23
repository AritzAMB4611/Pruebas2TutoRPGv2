using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float velocity;

    private InputPlayer inputPlayer;
    private Transform transformPlayer;
    private Rigidbody2D rb2D;
    private Animator animator;
    private SpriteRenderer spriteRenderer;

    private float horizontal;
    private float vertical;
    int runHashCode;

    // Start is called before the first frame update
    void Start()
    {
        inputPlayer = GetComponent<InputPlayer>();
        transformPlayer = GetComponent<Transform>();
        rb2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        runHashCode = Animator.StringToHash("corriendo");
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = inputPlayer.ejeHorizontal;
        vertical = inputPlayer.ejeVertical;

        // FlipSprite();

        if (horizontal != 0 || vertical != 0)
        {
            SetXYAnimator();
            animator.SetBool(runHashCode, true);
        }
        else
        {
            animator.SetBool(runHashCode, false);
        }
    }

    //Para fisicas
    void FixedUpdate()
    {
        Vector2 vectorVelocidad = new Vector2(horizontal, vertical) * velocity;
        rb2D.velocity = vectorVelocidad;
    }


    //METODOS
    private void FlipSprite()
    {
        if (horizontal < 0 && Mathf.Abs(vertical) <= Mathf.Abs(horizontal))
        {
            spriteRenderer.flipX = true;
        }
        else if (horizontal != 0)
        {
            spriteRenderer.flipX = false;
        }
    }

    private void SetXYAnimator()
    {
        animator.SetFloat("x", horizontal);
        animator.SetFloat("y", vertical);
    }


}
