
using System.Collections.Generic;

class Room {
	
	public ISet<Entity> entities = new HashSet<Entity>();
	
	public string name {get;}
	
	public Room(string name){
		this.name = name;
	}
	
}
