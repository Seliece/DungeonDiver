extends RigidBody2D


# Called when the node enters the scene tree for the first time.
func _ready():
	get_node(get_parent().get_child(Camera2D))
	pass # Replace with function body.


# Called every frame. 'delta' is the elapsed time since the previous frame.
func _process(delta):
	pass
