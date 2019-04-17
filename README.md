# Enemy---VR-Stealth

## Vision

Enemy will detect player via a SphereCollider Trigger with a default range of 10. Upon contact with the player, a ray will be cast from the enemy to the player. If the ray hits the player, a static boolean variable 'playerDetect' will be set to true, alerting all enemies that the player is detected. A static reference of the last sighting of the player will also be updated.

## Pathfinding

Pathfinding is done via a NavMesh

## Player Control

Control the player with WASD keys. The camera will automatically follow the player from a top-down view

### Note

Enable Gizmos in Game View to see the vision of the enemy. A red line will appear when the enemy detects the player. The green line indicates the last sighting of the player that the enemy will move to.
