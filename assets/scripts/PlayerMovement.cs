using Godot;
using System;

public class PlayerMovement : KinematicBody2D
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";

    [Export] public int speed = 200;
    public Vector2 velocity = new Vector2();

    public void GetInput()
    {
        velocity = new Vector2();

        // if (Input.IsActionPressed("right"))
        //     velocity.x += 1;

        // if (Input.IsActionPressed("left"))
        //     velocity.x -= 1;

        if (Input.IsActionPressed("down"))
            velocity.y += 1;

        if (Input.IsActionPressed("up"))
            velocity.y -= 1;

        velocity = velocity.Normalized() * speed;
    }

    public override void _PhysicsProcess(float delta)
    {
        GetInput();
        velocity = MoveAndSlide(velocity);
    }

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
