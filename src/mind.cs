

interface Mind {
	
	public void observe(GameEvent gameEvent);
	public ConcreteCommand decideAction(Room room, Entity body);
	
}
