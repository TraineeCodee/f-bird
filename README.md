

How It Works

Movement

    Reads horizontal input using Input.GetAxisRaw("Horizontal").

    Applies velocity in FixedUpdate() for smooth physics movement.

Jumping

    Pressing Jump (Space by default) sets upward velocity.

    Releasing jump early cuts velocity in half → shorter jumps.

Flipping

    Checks if the player changes direction.

    Flips the character’s localScale.x to face the correct side.
