using Godot;
using System;

public partial class PlayerController : RigidBody2D
{
	int speed = 10000;
	public override void _Process(double delta)
	{
		Vector2 direction = getDirection();
		LinearVelocity = new Vector2((float)(direction.X * delta * speed), (float)(direction.Y * delta * speed));
	}
	
	Vector2 getDirection() {
		Vector2 direction = new Vector2(0, 0);
		if (Input.IsKeyPressed(Key.A)) {
			direction.X += -1;
		}
		
		if (Input.IsKeyPressed(Key.D)) {
			direction.X += 1;
		}
		
		if (Input.IsKeyPressed(Key.W)) {
			direction.Y += 1;
		}
		return direction;
	}
}
