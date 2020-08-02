

interface Mind {
	
	public void observe(GameEvent gameEvent);
	public ConcreteCommand decideAction(RoomData room, Entity body);
	
}
