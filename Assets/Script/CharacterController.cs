using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public KeyCode Forward = KeyCode.UpArrow;
    public KeyCode Turn = KeyCode.RightArrow;
    
    
    public float maxSpeed = 3.4f;
    public float jumpHeight = 6.5f;
    public Camera mainCamera;
    bool faceRight = true;
    float switchDirection = 0;
    bool isGrounded = false;
    Vector3 cameraPos;
    Rigidbody2D rb2d;
    CapsuleCollider2D mainCollider;
    Transform trs;

    void Start()
    {
        trs = transform;
        rb2d = GetComponent<Rigidbody2D>();
        mainCollider = GetComponent<CapsuleCollider2D>();
        rb2d.freezeRotation = true;
        rb2d.collisionDetectionMode = CollisionDetectionMode2D.Continuous;
        faceRight = trs.localScale.x > 0;

        if (mainCamera)
        {
            cameraPos = mainCamera.transform.position;
        }
    }


    void Update()
    {
        ControlCharacter();

        //Changement Gauche / Droite
        if (switchDirection != 0) DirectionSwitch();
    }

    void FixedUpdate()
    {
        Bounds colliderBounds = mainCollider.bounds;
        float colliderRadius = mainCollider.size.x * 0.4f * Mathf.Abs(transform.localScale.x);
        Vector2 groundCheckPos = colliderBounds.min + new Vector3(colliderBounds.size.x * 0.5f, colliderRadius * 0.9f, 0);
        // V�rification du grounded
        Collider2D[] colliders = Physics2D.OverlapCircleAll(groundCheckPos, colliderRadius);
        // V�rification du ColliderCharacter par (true ou false)
        isGrounded = false;
        if (colliders.Length > 0)
        {
            for (int i = 0; i < colliders.Length; i++)
            {
                if (colliders[i] != mainCollider)
                {
                    isGrounded = true;
                    break;
                }
            }
        }

        //Application de la velocit�
        rb2d.velocity = new Vector3((switchDirection) * maxSpeed * Time.deltaTime , rb2d.velocity.y);


    }

    void ControlCharacter()
    {
        if ((Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D)) && (isGrounded || Mathf.Abs(rb2d.velocity.x) > 0.01f))
        {
            switchDirection = Input.GetKey(KeyCode.A) ? -1 : 1;
        }
        else
        {
            if (isGrounded || rb2d.velocity.magnitude < 0.01f)
            {
                switchDirection = 0;
            }
        }
    }

    void DirectionSwitch()
    {
        if (switchDirection > 0 && !faceRight)
        {
            faceRight = true;
            trs.localScale = new Vector3(Mathf.Abs(trs.localScale.x), trs.localScale.y, transform.localScale.z);
        }
        if (switchDirection < 0 && faceRight)
        {
            faceRight = false;
            trs.localScale = new Vector3(-Mathf.Abs(trs.localScale.x), trs.localScale.y, trs.localScale.z);
        }

    }

}