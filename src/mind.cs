

interface Mind {
	
	public void observe(GameEvent gameEvent);
	public Action decideAction(); // todo: accept room state
	public Entity getBody();
	
}
