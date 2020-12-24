using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    Vector2 Movement; //Directions of player
    public float Speed; //Speed of player
    public float ReloadTimer;
    public bool IsShooting; //Determines whether the player is shooting or not
    private Rigidbody2D RB;
    private BoxCollider2D BC;

    IEnumerator StopShooting()
    {
        yield return new WaitForSeconds(ReloadTimer);
        IsShooting = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody2D>(); //Activates the player's Rigidbody2D
        BC = GetComponent<BoxCollider2D>(); //Activates the player's BoxCollider2D

    }

    // Update is called once per frame
    void Update()
    {
        RB.velocity = new Vector2(Movement.x, Movement.y) * Time.deltaTime * Speed; //Player movement

        BC.enabled = false; //Disables the BoxCollider2D

        if (IsShooting)
        {
            BC.enabled = true; //Enables the BoxCollider2D
            //IsShooting = false;
            StartCoroutine(StopShooting());
        }

    }


    #region InputActions
    //Setting up movement
    public void OnMove(InputAction.CallbackContext ctx)
    {
        Movement = ctx.ReadValue<Vector2>();
    }

    //Setting up shooting mechanics
    public void OnShoot(InputAction.CallbackContext ctx)
    {
        if (ctx.phase == InputActionPhase.Performed)
        {
            IsShooting = true;
        }
    }
    #endregion
}
