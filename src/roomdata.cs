
using System.Collections.Generic;

class RoomData {
	
	public ISet<Entity> entities = new HashSet<Entity>();
	
	public string name {get;}
	
	public RoomData(string name){
		this.name = name;
	}
	
}
