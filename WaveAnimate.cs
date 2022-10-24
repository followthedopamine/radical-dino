using Godot;
using System;

public class WaveAnimate : Sprite
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";

    // Called when the node enters the scene tree for the first time.

    public AnimationPlayer animation; 
    public override void _Ready()
    {
        animation = ((AnimationPlayer)GetNode("AnimationPlayer"));
        animation.Play("WaveBounce");
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
