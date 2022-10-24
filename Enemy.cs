using Godot;
using System;

public class Enemy : KinematicBody2D
{
    [Export] public int speed = 200;
    public Vector2 velocity = new Vector2();

    public override void _Ready()
    {
        velocity.x = -1 * speed;
    }

    public override void _PhysicsProcess(float delta)
    {
        velocity = MoveAndSlide(velocity);
    }
    

    // TODO: When off screen remove the object
    // TODO: Kill player when collides with player
}
