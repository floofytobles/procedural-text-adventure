

public interface Mind {
	
	public void observe(GameEvent gameEvent);
	public GameCommand decideAction(Entity body, Room room);
	
}
