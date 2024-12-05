using Godot;
using System;

public partial class CameraController : Camera2D
{

	public override void _Process(double delta)
	{
		Position = GetNode<RigidBody2D>("%Player").Position;
	}
}
