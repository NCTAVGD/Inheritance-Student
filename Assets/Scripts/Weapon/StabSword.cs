using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StabSword : Weapon
{
    public GameObject spritePrefab; // Prefab of the sprite to spawn
    public float moveSpeed = 5f; // Speed at which the sprite moves
    public float moveDistance = 10f; // Distance the sprite moves forward and backward
    public float despawnDelay = 2f; // Delay before despawning the sprite

    private GameObject currentSprite; // Reference to the spawned sprite
    private bool isMovingForward = true; // Flag indicating the sprite's movement direction
    private float currentDistance = 0f; // Current distance covered by the sprite

    private void Start()
    {
        SpawnSprite();
    }

    private void Update()
    {
        if (currentSprite != null)
        {
            // Move the sprite forward or backward based on the current direction
            float movement = moveSpeed * Time.deltaTime * (isMovingForward ? 1f : -1f);
            currentSprite.transform.Translate(Vector3.right * movement);

            // Update the distance covered by the sprite
            currentDistance += Mathf.Abs(movement);

            // Check if the sprite has reached the maximum distance
            if (currentDistance >= moveDistance)
            {
                // Change the direction and reset the distance
                isMovingForward = !isMovingForward;
                currentDistance = 0f;

                // Despawn the sprite after a delay
                Invoke("DespawnSprite", despawnDelay);
            }
        }
    }

    private void SpawnSprite()
    {
        // Instantiate the sprite prefab at the desired position
        currentSprite = Instantiate(spritePrefab, transform.position, Quaternion.identity);
    }

    private void DespawnSprite()
    {
        // Destroy the sprite game object
        Destroy(currentSprite);
        currentSprite = null;
    }
}
